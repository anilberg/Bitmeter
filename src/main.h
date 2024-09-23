#ifndef __TEMPLATE_H__
#define __TEMPLATE_H__

#include "wx/wx.h"
#include "frame.h"

class Bitmeter : public wxApp
{
    public:
        virtual bool OnInit();
};

DECLARE_APP(Bitmeter)

#endif  // __TEMPLATE_H__
