Module moduleProcesses

    'Variable to hold the current user ID as session
    Public CurrentUserID As Integer
    Public Function calcYearExpenses(ByVal opr1 As Double,
                                 ByVal opr2 As Double,
                                 ByVal opr3 As Double) As Double
        'Variable declaration
        Dim yearExp As Double

        yearExp = (0.01 * opr1) + (0.005 * opr1) + opr2 + opr3

        Return yearExp

    End Function

    Public Function calcDownpayment(ByVal opr1 As Double,
                                    ByVal opr2 As Double) As Double

        'Variable declaration
        Dim downPay As Double
        downPay = opr1 * opr2

        Return downPay
    End Function


    Public Function calcYearInstall(ByVal opr1 As Double,
                                    ByVal opr2 As Double,
                                    ByVal opr3 As Integer) As Double

        'Variable declaration
        Dim yearInstall As Double
        yearInstall = (opr1 - opr2) / opr3

        Return yearInstall

    End Function


    Public Function calcTotYear(ByVal opr1 As Double,
                                ByVal opr2 As Double) As Double
        'Variable declaration
        Dim totYear As Double
        totYear = opr1 + opr2

        Return totYear
    End Function

    Public Function calcMonthPay(ByVal opr1 As Double) As Double
        'Variable declaration
        Dim monthPay As Double
        monthPay = opr1 / 12

        Return monthPay
    End Function

    Public Function calcMinSal(ByVal opr1 As Double,
                               ByVal opr2 As Double) As Double
        'Variable declaration
        Dim minSal As Double
        minSal = opr1 / opr2

        Return minSal
    End Function



End Module
