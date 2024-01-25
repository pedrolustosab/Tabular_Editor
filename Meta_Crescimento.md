PRECO_T = 
[#PRECO] - [#META]

PRECO_%T = 
DIVIDE (
    [PRECO_T],
    [#META]
)

PRECO_%T_FORMAT =
FORMAT (
    [PRECO_%T],
    "  ⮝0.0%  ;  ⮟-0.0%  ",
    "pt-BR"
)

PRECO_%T_CLR = 
SWITCH (
    TRUE (),
    [PRECO_%T] <= -0.05, "#C0433A",
    [PRECO_%T] >= 0.05, "#79C75B",
    "#B2A424"
)

Nenhum = 
SELECTEDMEASURE()

Acima da Meta = 
IF(
    [PRECO_%T] > 0
    , SELECTEDMEASURE()
)

Crecimento = 
IF(
    [#PRECO_YoY] > 0
    , SELECTEDMEASURE()
)