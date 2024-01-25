R$ = 
SELECTEDMEASURE()

USD = 
    SWITCH(
        TRUE()
        , ISSELECTEDMEASURE([#PRECO], [#PRECO_DUMMY])
            , [#PRECO]/[Dolar]
        , SELECTEDMEASURE()
    )