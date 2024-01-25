Emissão = 
CALCULATE(
    SELECTEDMEASURE(),
    USERELATIONSHIP(
        'fNotas'[DT_EMISSAO]
        , 'dCalendario'[Data]
    )
)

Entrega = 
CALCULATE(
    SELECTEDMEASURE(),
    USERELATIONSHIP(
        'fNotas'[DT_ENTREGA]
        , 'dCalendario'[Data]
    )
)