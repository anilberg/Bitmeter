from tkinter import *
from tkinter import ttk
#from tkinter import messagebox
#from tkinter import _setit
#import threading

#import matplotlib.pyplot as plt
#from matplotlib.backends.backend_tkagg import FigureCanvasTkAgg

BIT_LEN = 16

# =========================================================================== #
#   ROOT GUI
# =========================================================================== #
class RootGUI():
    def __init__(self):
        '''
        Initializing the root GUI and other comps of the program
        '''
        self.root = Tk()
        self.root.title    ("test")
        self.root.geometry ("470x550")
        self.root.resizable(False, False)
        self.root.config   (bg="white")

        self.root.protocol("WM_DELETE_WINDOW", self.closeWindow)

    # ----------------------------------------------------------------------- #
    def closeWindow(self):
        if __debug__:
            print("Closing the window and exit!")

        self.root.destroy()

# =========================================================================== #
#   BITS GUI
# =========================================================================== #
class BitsGUI():
    def __init__(self, root):
        self.root = root

        self.bitLabelFrame0 = Frame(self.root, bg="white")
        self.bitBoxFrame0   = Frame(self.root, bg="white")

        self.bitLabelFrame1 = Frame(self.root, bg="white")
        self.bitBoxFrame1   = Frame(self.root, bg="white")

        self.bitBoxes0       = []
        self.bitBoxVars0     = []
        self.dummySeparator0 = []

        self.bitBoxes1       = []
        self.bitBoxVars1     = []
        self.dummySeparator1 = []

    # ----------------------------------------------------------------------- #
    def addBitBoxes(self):
        '''
        Initializing the bit boxes and labels
        '''
        # ------------------------------------------------------------------- #
        # [15:0] bits
        # ------------------------------------------------------------------- #
        self.zeroLabel = Label(self.bitLabelFrame0, text="0", 
                                        bg="white", fg="black", width=3)
        self.zeroLabel.pack(side=RIGHT)

        self.fifteenLabel = Label(self.bitLabelFrame0, text="15", 
                                        bg="white", fg="black", width=3)
        self.fifteenLabel.pack(side=LEFT)
        
        # ------------------------------------------------------------------- #
        for i in range(0, BIT_LEN):
            self.bitBoxVars0.append(IntVar())

            self.bitBoxes0.append(Checkbutton(self.bitBoxFrame0, text='', 
                                      variable=self.bitBoxVars0[i], onvalue=1, 
                                      offvalue=0, bg="white", state="active",
                                      command=self.calcValue))
            
            self.bitBoxes0[i].pack(side=RIGHT)

            if (i + 1) % 4 == 0 and i != 15:
                self.dummySeparator0.append(Label(self.bitBoxFrame0, text="", 
                                                 bg="gray", fg="black"))
                
                self.dummySeparator0[int(i/4)].pack(side=RIGHT)
        
        # ------------------------------------------------------------------- #
        # [31:16] bits
        # ------------------------------------------------------------------- #
        self.sixteenLabel = Label(self.bitLabelFrame1, text="16", 
                                        bg="white", fg="black", width=3)
        self.sixteenLabel.pack(side=RIGHT)

        self.thirtyoneLabel = Label(self.bitLabelFrame1, text="31", 
                                        bg="white", fg="black", width=3)
        self.thirtyoneLabel.pack(side=LEFT)

        # ------------------------------------------------------------------- #
        for i in range(0, BIT_LEN):
            self.bitBoxVars1.append(IntVar())

            self.bitBoxes1.append(Checkbutton(self.bitBoxFrame1, text='', 
                                      variable=self.bitBoxVars1[i], onvalue=1, 
                                      offvalue=0, bg="white", state="active",
                                      command=self.calcValue))
            
            self.bitBoxes1[i].pack(side=RIGHT)

            if (i + 1) % 4 == 0 and i != 15:
                self.dummySeparator1.append(Label(self.bitBoxFrame1, text="", 
                                                 bg="gray", fg="black"))
                
                self.dummySeparator1[int(i/4)].pack(side=RIGHT)

        # ------------------------------------------------------------------- #
        self.bitLabelFrame1.pack(fill=X)
        self.bitBoxFrame1.pack(fill=X)

        self.bitLabelFrame0.pack(fill=X)
        self.bitBoxFrame0.pack(fill=X)

    # ----------------------------------------------------------------------- #
    def calcValue(self):
        self.resultDec = 0

        for cnt, state in enumerate(self.bitBoxVars0):
            self.resultDec += state.get()*pow(2, cnt)

        for cnt, state in enumerate(self.bitBoxVars1):
            self.resultDec += state.get()*pow(2, cnt + 16)

        print(f'resultDecimal: {self.resultDec}')
        print(f'resultHex: {hex(self.resultDec)}')
        
# =========================================================================== #
#   RESULT GUI
# =========================================================================== #
class ResultGUI():
    def __init__(self, root, bits):
        self.root = root
        self.bits = bits

        self.resultFrame = Frame(self.root, bg="white")

        self.resultDec = 0

        self.publish()

    # ----------------------------------------------------------------------- #
    def publish(self):
        self.bits.addBitBoxes()
        self.addResultFrame()

    # ----------------------------------------------------------------------- #
    def addResultFrame(self):
        self.DecLabel = Label(self.resultFrame, text="Decimal: ", 
                                        bg="white", fg="black")
        
        self.HexLabel = Label(self.resultFrame, text="Hex: ", 
                                        bg="white", fg="black")
        
        self.resultDecLabel = Label(self.resultFrame, text=f'{self.resultDec}')

        self.resultHexLabel = Label(self.resultFrame, 
                                    text=f'{hex(self.resultDec)}')

        self.DecLabel.grid(row=0, column=3, padx=5, pady=5,
                                 sticky='e')
        self.HexLabel.grid(row=1, column=3, padx=5, pady=5,
                                 sticky='e')
        
        
        self.resultDecLabel.grid(row=0, column=4, columnspan=3, padx=5, pady=5)
        self.resultHexLabel.grid(row=1, column=4, columnspan=3, padx=5, pady=5)

        self.resultFrame.pack(fill=X)

    # ----------------------------------------------------------------------- #
    def updateResult(self):
        self.resultDecLabel['text'] = '111'