// ########################################################################## //
//  INCLUDES
// ########################################################################## //
#include "frame.h"

// ########################################################################## //
//  FUNCTIONS
// ########################################################################## //
frame::frame(const wxString& title) : wxFrame(NULL, wxID_ANY, title, wxDefaultPosition, wxSize(370, 200), wxDEFAULT_FRAME_STYLE ^ wxRESIZE_BORDER)
{
    SetIcon(wxIcon(wxT("img/icon.xpm")));

    result = 0;

    // ---------- FIRST ROW ---------- //
    for(int i = 31; i >= 16; i--)
    {
        if(i == 31)
        {
            chboxes[i] = new wxCheckBox(this, CHBOX_IDS[i], wxT(""), wxPoint(10,  20), wxDefaultSize);
            Connect(CHBOX_IDS[i], wxEVT_CHECKBOX, wxCommandEventHandler(frame::onChBox));
            continue;
        }

        if(i % 4 == 3)
        {
            chboxes[i] = new wxCheckBox(this, CHBOX_IDS[i], wxT(""), wxPoint(chboxes[i + 1]->GetPosition().x + 30,  20), wxDefaultSize);
        }
        else
        {
            chboxes[i] = new wxCheckBox(this, CHBOX_IDS[i], wxT(""), wxPoint(chboxes[i + 1]->GetPosition().x + 20,  20), wxDefaultSize);
        }

        Connect(CHBOX_IDS[i], wxEVT_CHECKBOX, wxCommandEventHandler(frame::onChBox));
    }

    // ---------- SECOND ROW ---------- //
    for(int i = 15; i >= 0; i--)
    {
        if(i == 15)
        {
            chboxes[i] = new wxCheckBox(this, CHBOX_IDS[i], wxT(""), wxPoint(10,  60), wxDefaultSize);
            Connect(CHBOX_IDS[i], wxEVT_CHECKBOX, wxCommandEventHandler(frame::onChBox));
            continue;
        }

        if(i % 4 == 3)
        {
            chboxes[i] = new wxCheckBox(this, CHBOX_IDS[i], wxT(""), wxPoint(chboxes[i + 1]->GetPosition().x + 30,  60), wxDefaultSize);
        }
        else
        {
            chboxes[i] = new wxCheckBox(this, CHBOX_IDS[i], wxT(""), wxPoint(chboxes[i + 1]->GetPosition().x + 20,  60), wxDefaultSize);
        }

        Connect(CHBOX_IDS[i], wxEVT_CHECKBOX, wxCommandEventHandler(frame::onChBox));
    }

    m_text31 = new wxStaticText(this, -1, wxT("31"), wxPoint(10,  5));
    m_text28 = new wxStaticText(this, -1, wxT("28"), wxPoint(70,  5));
    m_text27 = new wxStaticText(this, -1, wxT("27"), wxPoint(100, 5));
    m_text24 = new wxStaticText(this, -1, wxT("24"), wxPoint(160, 5));
    m_text23 = new wxStaticText(this, -1, wxT("23"), wxPoint(190, 5));
    m_text20 = new wxStaticText(this, -1, wxT("20"), wxPoint(250, 5));
    m_text19 = new wxStaticText(this, -1, wxT("19"), wxPoint(280, 5));
    m_text16 = new wxStaticText(this, -1, wxT("16"), wxPoint(340, 5));
    m_text15 = new wxStaticText(this, -1, wxT("15"), wxPoint(10,  45));
    m_text12 = new wxStaticText(this, -1, wxT("12"), wxPoint(70,  45));
    m_text11 = new wxStaticText(this, -1, wxT("11"), wxPoint(100, 45));
    m_text8  = new wxStaticText(this, -1, wxT("8"),  wxPoint(165, 45));
    m_text7  = new wxStaticText(this, -1, wxT("7"),  wxPoint(195, 45));
    m_text4  = new wxStaticText(this, -1, wxT("4"),  wxPoint(255, 45));
    m_text3  = new wxStaticText(this, -1, wxT("3"),  wxPoint(285, 45));
    m_text0  = new wxStaticText(this, -1, wxT("0"),  wxPoint(345, 45));

    // ---------- Buttons ---------- //
    m_btn_shl = new wxButton(this, ID_SHL, wxT("<<"), wxPoint(45, 100));
    m_btn_shr = new wxButton(this, ID_SHR, wxT(">>"), wxPoint(145, 100));
    m_btn_clr = new wxButton(this, ID_CLR, wxT("Clear"), wxPoint(245, 100));

    Connect(ID_CLR, wxEVT_COMMAND_BUTTON_CLICKED, wxCommandEventHandler(frame::onClear));
    Connect(ID_SHL, wxEVT_COMMAND_BUTTON_CLICKED, wxCommandEventHandler(frame::onSHLL));
    Connect(ID_SHR, wxEVT_COMMAND_BUTTON_CLICKED, wxCommandEventHandler(frame::onSHRL));

    // ---------- Result ---------- //
    m_decimal_text = new wxStaticText(this, -1, wxT("Dec:"), wxPoint(10, 150));
    m_decimalResult_text = new wxTextCtrl(this, wxID_ANY, wxT("0"), wxPoint(45, 145), wxDefaultSize, wxTE_READONLY);

    m_hex_text = new wxStaticText(this, -1, wxT("Hex:"), wxPoint(200, 150));
    m_hexResult_text = new wxTextCtrl(this, wxID_ANY, wxT("0x00000000"), wxPoint(235, 145), wxDefaultSize, wxTE_READONLY);

    // ---------- Sign ---------- //
    CreateStatusBar(1);
    SetStatusText(wxT("by anilberg"));
}

// ========================================================================== //
void frame::calcResult(void)
{
    result = 0;

    for(int i = 31; i >= 0; i--)
    {
        if(chboxes[i]->GetValue())
        {
            result += pow(2, CHBOX_IDS[i]);
        }
    }

    m_decimalResult_text->ChangeValue(wxString::Format(wxT("%ld"), result));
    m_hexResult_text->ChangeValue(wxString::Format(wxT("0x%08lx"), result));
}

// ========================================================================== //
void frame::onClear(wxCommandEvent & WXUNUSED(event))
{
    for(int i = 31; i >= 0; i--)
    {
        chboxes[i]->SetValue(0);
    }

    m_decimalResult_text->ChangeValue(wxT("0"));
    m_hexResult_text->ChangeValue(wxString::Format(wxT("0x00000000"), result));
}

// ========================================================================== //
void frame::onSHLL(wxCommandEvent & WXUNUSED(event))
{
    for(int i = 31; i >= 0; i--)
    {
        if(i == 0)
        {
            chboxes[i]->SetValue(0);
        }
        else
        {
            chboxes[i]->SetValue(chboxes[i - 1]->GetValue());
        }
    }

    calcResult();
}

// ========================================================================== //
void frame::onSHRL(wxCommandEvent & WXUNUSED(event))
{
    for(int i = 0; i < 32; i++)
    {
        if(i == 31)
        {
            chboxes[i]->SetValue(0);
        }
        else
        {
            chboxes[i]->SetValue(chboxes[i + 1]->GetValue());
        }
    }

    calcResult();
}

// ========================================================================== //
void frame::onChBox(wxCommandEvent &event)
{
    wxCheckBox *obj = (wxCheckBox *) event.GetEventObject();

    // Write Result
    if(obj->GetValue()) // If checked
    {
        result += pow(2, event.GetId());
    }
    else
    {
        result -= pow(2, event.GetId());
    }

    m_decimalResult_text->ChangeValue(wxString::Format(wxT("%ld"), result));
    m_hexResult_text->ChangeValue(wxString::Format(wxT("0x%08lx"), result));
}
