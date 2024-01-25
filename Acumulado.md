Normal = 
SELECTEDMEASURE()

Acumulado =
CALCULATE(
    SELECTEDMEASURE()
    ,FILTER(
        ALLSELECTED(dCalendario[Data]),
        dCalendario[Data] <= MAX(dCalendario[Data])
    )
)