from gui_master import RootGUI, BitsGUI

# =========================================================================== #
#   INITIALIZATION
# =========================================================================== #
if __debug__:
    print('Debug On!')

RootMaster = RootGUI()
BitMaster  = BitsGUI(RootMaster.root)

# =========================================================================== #
#   MAIN LOOP
# =========================================================================== #
# Start the Graphic User Interface
RootMaster.root.mainloop()
