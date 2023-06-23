from tkinter import *

BIT_LEN = 32

# =========================================================================== #
#   ROOT GUI
# =========================================================================== #
class RootGUI():
    def __init__(self):
        '''
        Initializing the root GUI and other comps of the program
        '''
        self.root = Tk()
        self.root.title    ("Bitmeter")
        self.root.geometry ("470x160")
        self.root.resizable(False, False)
        self.root.config   (bg="white")
        self.root.wm_iconbitmap('test.ico')

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

        self.publish()

    # ----------------------------------------------------------------------- #
    def publish(self):
        self.addBitBoxes()
        self.resultGui  = ResultGUI (self.root)
        self.controlGui = ControlGUI(self.root, self)
        self.creditGUI  = CreditGUI (self.root)

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
        for i in range(0, int(BIT_LEN/2)):
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
        for i in range(0, int(BIT_LEN/2)):
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
        self.bitBoxFrame1.pack  (fill=X)

        self.bitLabelFrame0.pack(fill=X)
        self.bitBoxFrame0.pack  (fill=X)

    # ----------------------------------------------------------------------- #
    def calcValue(self):
        self.resultDec = 0

        for cnt, state in enumerate(self.bitBoxVars0):
            self.resultDec += state.get()*pow(2, cnt)

        for cnt, state in enumerate(self.bitBoxVars1):
            self.resultDec += state.get()*pow(2, cnt + 16)

        self.resultGui.decString.set(f'{self.resultDec}')
        self.resultGui.hexString.set(f'{hex(self.resultDec)}')

        if __debug__:
            print(f'resultDecimal: {self.resultDec}')
            print(f'resultHex: {hex(self.resultDec)}')
        
# =========================================================================== #
#   RESULT GUI
# =========================================================================== #
class ResultGUI():
    def __init__(self, root):
        self.root = root

        self.resultFrame = Frame(self.root, bg="white")

        self.resultDec = 0

        self.addResultFrame()

    # ----------------------------------------------------------------------- #
    def addResultFrame(self):
        self.DecLabel = Label(self.resultFrame, text="Decimal: ", 
                                bg="white", fg="black", width=15)
        
        self.HexLabel = Label(self.resultFrame, text="Hex: ", 
                                bg="white", fg="black", width=15)
        
        self.decString = StringVar()
        self.hexString = StringVar()
        self.decString.set('0')
        self.hexString.set(f'{hex(0)}')

        self.decEntry = Entry(self.resultFrame, textvariable=self.decString,
                         fg="black", bg="white", bd=0, state="readonly")

        self.hexEntry = Entry(self.resultFrame, textvariable=self.hexString,
                         fg="black", bg="white", bd=0, state="readonly")
        
        
        self.decEntry.grid(row=0, column=4, padx=5, pady=5)
        self.hexEntry.grid(row=1, column=4, padx=5, pady=5)
        
        self.DecLabel.grid(row=0, column=0, padx=5, pady=5, sticky='e')
        self.HexLabel.grid(row=1, column=0, padx=5, pady=5, sticky='e')

        self.resultFrame.pack(side=LEFT)

# =========================================================================== #
#   CONTROL GUI
# =========================================================================== #
class ControlGUI():
    def __init__(self, root, bits):
        self.root = root
        self.bits = bits

        self.controlFrame = Frame(self.root, bg="white")

        self.addControlFrame()

    # ----------------------------------------------------------------------- #
    def addControlFrame(self):
        self.lShiftButton = Button(self.controlFrame, text='<<',
                                    command=self.leftShift)
        
        self.rShiftButton = Button(self.controlFrame, text='>>',
                                    command=self.rightShift)

        self.resetButton = Button(self.controlFrame, text='Reset',
                                    command=self.reset)
        
        self.lShiftButton.grid(row=0, column=0, rowspan=3, padx=5, pady=5)

        self.rShiftButton.grid(row=0, column=1, rowspan=3, padx=5, pady=5)
        
        self.resetButton.grid(row=0, column=2, rowspan=3, padx=5, pady=5)

        self.controlFrame.pack(side=LEFT)

    # ----------------------------------------------------------------------- #
    def reset(self):
        if __debug__:
            print('Reset!')

        for _, state in enumerate(self.bits.bitBoxVars0):
            state.set(0)

        for _, state in enumerate(self.bits.bitBoxVars1):
            state.set(0)

        self.bits.calcValue()

    # ----------------------------------------------------------------------- #
    def leftShift(self):
        if __debug__:
            print('Left Shift!')

        self.temp = []

        # ------------------------------------------------------------------- #
        for cnt, state in enumerate(self.bits.bitBoxVars0):
            self.temp.append(state.get())

        for cnt, state in enumerate(self.bits.bitBoxVars1):
            self.temp.append(state.get())

        # ------------------------------------------------------------------- #
        self.temp.insert(0, 0)

        del self.temp[-1]

        # ------------------------------------------------------------------- #
        for cnt, state in enumerate(self.bits.bitBoxVars0):
            state.set(self.temp[cnt])

        for cnt, state in enumerate(self.bits.bitBoxVars1):
            state.set(self.temp[cnt + 16])

        # ------------------------------------------------------------------- #
        self.bits.calcValue()

    # ----------------------------------------------------------------------- #
    def rightShift(self):
        if __debug__:
            print('Right Shift!')

        self.temp = []

        # ------------------------------------------------------------------- #
        for cnt, state in enumerate(self.bits.bitBoxVars0):
            self.temp.append(state.get())

        for cnt, state in enumerate(self.bits.bitBoxVars1):
            self.temp.append(state.get())

        # ----------------------------------------------------------------------- #
        self.temp.append(0)

        del self.temp[0]

        # ----------------------------------------------------------------------- #
        for cnt, state in enumerate(self.bits.bitBoxVars0):
            state.set(self.temp[cnt])

        for cnt, state in enumerate(self.bits.bitBoxVars1):
            state.set(self.temp[cnt + 16])

        # ----------------------------------------------------------------------- #
        self.bits.calcValue()

# =========================================================================== #
#   CREDIT GUI
# =========================================================================== #
class CreditGUI():
    def __init__(self, root):
        self.root = root

        self.creditFrame = Frame(self.root, bg="white")

        self.addcreditFrame()

    # ----------------------------------------------------------------------- #
    def addcreditFrame(self):
        self.creditLabel = Label(self.creditFrame, text='by anilberg\n2023', 
                                 background='white')

        self.creditLabel.pack(fill=X, padx=10, pady=15)

        self.creditFrame.pack(fill=X)
