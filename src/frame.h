/*
 *
 *
 * */
#ifndef __PANEL_H__
#define __PANEL_H__

// ########################################################################## //
//  INCLUDES
// ########################################################################## //
#include <wx/wx.h>
#include <wx/panel.h>

// ########################################################################## //
//  DEFINES
// ########################################################################## //
#define ID_CLR 101
#define ID_SHL 102
#define ID_SHR 103

#define ID_CHBOX0  0
#define ID_CHBOX1  1
#define ID_CHBOX2  2
#define ID_CHBOX3  3
#define ID_CHBOX4  4
#define ID_CHBOX5  5
#define ID_CHBOX6  6
#define ID_CHBOX7  7
#define ID_CHBOX8  8
#define ID_CHBOX9  9
#define ID_CHBOX10 10
#define ID_CHBOX11 11
#define ID_CHBOX12 12
#define ID_CHBOX13 13
#define ID_CHBOX14 14
#define ID_CHBOX15 15
#define ID_CHBOX16 16
#define ID_CHBOX17 17
#define ID_CHBOX18 18
#define ID_CHBOX19 19
#define ID_CHBOX20 20
#define ID_CHBOX21 21
#define ID_CHBOX22 22
#define ID_CHBOX23 23
#define ID_CHBOX24 24
#define ID_CHBOX25 25
#define ID_CHBOX26 26
#define ID_CHBOX27 27
#define ID_CHBOX28 28
#define ID_CHBOX29 29
#define ID_CHBOX30 30
#define ID_CHBOX31 31

// ########################################################################## //
//
// ########################################################################## //
const int CHBOX_IDS[32] =
{
    ID_CHBOX0,  ID_CHBOX1,  ID_CHBOX2,  ID_CHBOX3,
    ID_CHBOX4,  ID_CHBOX5,  ID_CHBOX6,  ID_CHBOX7,
    ID_CHBOX8,  ID_CHBOX9,  ID_CHBOX10, ID_CHBOX11,
    ID_CHBOX12, ID_CHBOX13, ID_CHBOX14, ID_CHBOX15,
    ID_CHBOX16, ID_CHBOX17, ID_CHBOX18, ID_CHBOX19,
    ID_CHBOX20, ID_CHBOX21, ID_CHBOX22, ID_CHBOX23,
    ID_CHBOX24, ID_CHBOX25, ID_CHBOX26, ID_CHBOX27,
    ID_CHBOX28, ID_CHBOX29, ID_CHBOX30, ID_CHBOX31
};

// ########################################################################## //
//  FRAME CLASS
// ########################################################################## //
class frame : public wxFrame
{
    public:
        frame(const wxString &title);

        long int result;

        wxStaticText *m_decimal_text, *m_hex_text;

        wxTextCtrl *m_decimalResult_text, *m_hexResult_text;

        wxCheckBox* chboxes[32];

        wxButton *m_btn_clr, *m_btn_shl, *m_btn_shr;

        wxStaticText *m_text0,  *m_text3,  *m_text4,  *m_text7,
                     *m_text8,  *m_text11, *m_text12, *m_text15,
                     *m_text16, *m_text19, *m_text20, *m_text23,
                     *m_text24, *m_text27, *m_text28, *m_text31;

        void onChBox    (wxCommandEvent &event);
        void onClear    (wxCommandEvent &event);
        void onSHLL     (wxCommandEvent &event);
        void onSHRL     (wxCommandEvent &event);
        void calcResult (void);
};

#endif // __PANEL_H__
