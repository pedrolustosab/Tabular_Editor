Corrente =
SELECTEDMEASURE()

LM =
VAR _MES = 
    FORMAT(EDATE(MAX(dCalendario[Data]), -1), "YYYYMM")

RETURN
CALCULATE (
    SELECTEDMEASURE(),
    FILTER( 
        ALLSELECTED( dCalendario )
        , FORMAT(dCalendario[Data],"YYYYMM") = _MES
    )
   )

MoM (%)=
VAR CurrentAmount = SELECTEDMEASURE()
VAR _MES = 
    FORMAT(EDATE(MAX(dCalendario[Data]), -1), "YYYYMM")

VAR PreviousMonthAmount =
CALCULATE (
    SELECTEDMEASURE(),
    FILTER( 
        ALLSELECTED( dCalendario )
        , FORMAT(dCalendario[Data],"YYYYMM") = _MES
    )
   )
 
RETURN
    DIVIDE( CurrentAmount - PreviousMonthAmount, PreviousMonthAmount )

LY = 
CALCULATE (
    SELECTEDMEASURE(),
    SAMEPERIODLASTYEAR( dCalendario[Data] )
    )

YTD = 
CALCULATE( 
    SELECTEDMEASURE(), 
    DATESYTD ( dCalendario[Data] ) 
)

YoY = 
VAR CurrentAmount = SELECTEDMEASURE()
VAR PreviousYearAmount = 
    CALCULATE(
        SELECTEDMEASURE(),
        SAMEPERIODLASTYEAR( dCalendario[Data] )
        )
        
RETURN
    DIVIDE( CurrentAmount - PreviousYearAmount, PreviousYearAmount )