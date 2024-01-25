Nenhum = 
    SWITCH(
        TRUE
        , ISSELECTEDMEASURE([#PRECO])
            , [#PRECO]
        
    )

Max =
VAR _MaxValue = 
    MAXX(
        ALLSELECTED( 'dCalendario'[Data]),
        SELECTEDMEASURE()
    )
VAR _Valor = 
    SELECTEDMEASURE()

RETURN
    SWITCH(
        TRUE
        , ISSELECTEDMEASURE([#PRECO])
            , _Valor
        , ISSELECTEDMEASURE([#PRECO_DUMMY]) && _MaxValue = _Valor ,
            _MaxValue
        
    )

3 Melhores =
VAR _MaxValue = 
    TOPN (
       3,
       ALLSELECTED ('dCalendario'[Data]),
        [#PRECO]
    )
VAR _MaxDate = 
       MAX ('dCalendario'[Data])
RETURN
    SWITCH(
        TRUE
        , ISSELECTEDMEASURE([#PRECO])
            , [#PRECO]
        , ISSELECTEDMEASURE([#PRECO_DUMMY]) && _MaxDate in _MaxValue
            , [#PRECO_DUMMY]
        
    )

Min = 
VAR _MinValue = 
    MINX(
        ALLSELECTED( 'dCalendario'[Data]),
        SELECTEDMEASURE()
    )
VAR _Valor = 
    SELECTEDMEASURE()

RETURN
    SWITCH(
        TRUE
        , ISSELECTEDMEASURE([#PRECO])
            , _Valor
        , ISSELECTEDMEASURE([#PRECO_DUMMY]) && _MinValue = _Valor ,
            _MinValue
        
    )

3 Piores = 
VAR _MaxValue = 
    TOPN (
       3
       , FILTER( ALLSELECTED ('dCalendario'[Data]), [#PRECO])
       , [#PRECO]
       , ASC
    )
VAR _MaxDate = 
       MAX ('dCalendario'[Data])
RETURN
    SWITCH(
        TRUE
        , ISSELECTEDMEASURE([#PRECO])
            , [#PRECO]
        , ISSELECTEDMEASURE([#PRECO_DUMMY]) && _MaxDate in _MaxValue
            , [#PRECO_DUMMY]
        
    )