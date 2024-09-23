/*
 *
 *
 * */
// ########################################################################## //
//  INCLUDES
// ########################################################################## //
#include "main.h"

IMPLEMENT_APP(Bitmeter)

bool Bitmeter::OnInit()
{
    frame *app = new frame(wxT("Bitmeter"));
    app->Show(true);
    app->Center();

    return true;
}
