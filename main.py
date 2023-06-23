from gui_master    import RootGUI, BitsGUI, ResultGUI
#from serial_master import SerialCtrl
#from data_master   import DataMaster

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
