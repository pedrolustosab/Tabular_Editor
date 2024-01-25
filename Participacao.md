%P_GERAL_#PRECO = 
VAR _Coluna =
    MAX ( '_DIMENSÕES'[_DIMENSÕES Order] )
RETURN
    SWITCH (
        TRUE (),
        _Coluna = 0, [%P_FILIAL_[#PRECO]]],
        _Coluna = 1, [%P_PAGAMENTO_[#PRECO]]],
        _Coluna = 2, [%P_ESTADO_[#PRECO]]],
        _Coluna = 3, [%P_CATEGORIA_[#PRECO]]]
    )


%P_GERAL_#QUANTIDADE = 
VAR _Coluna =
    MAX ( '_DIMENSÕES'[_DIMENSÕES Order] )
RETURN
    SWITCH (
        TRUE (),
        _Coluna = 0, [%P_FILIAL_[#QUANTIDADE]]],
        _Coluna = 1, [%P_PAGAMENTO_[#QUANTIDADE]]],
        _Coluna = 2, [%P_ESTADO_[#QUANTIDADE]]],
        _Coluna = 3, [%P_CATEGORIA_[#QUANTIDADE]]]
    )

Faturamento = 
    SELECTEDMEASURE()

Quantidade = 
    SWITCH (
        TRUE ()
        , ISSELECTEDMEASURE( [#PRECO] )
            , [#QUANTIDADE]
        ,ISSELECTEDMEASURE( [%P_GERAL_#PRECO] )
            , [%P_GERAL_#QUANTIDADE]
        , SELECTEDMEASURE()
    )