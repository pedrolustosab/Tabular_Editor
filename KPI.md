Status Expression =
IF(
    [#PRECO_KPI]
    ,SWITCH(
        TRUE()
        ,[PRECO_%T] <= -0.05, -1
        ,[PRECO_%T] >= 0.05, 1
        , 0
    )
)

--Traffic Light - Single

Target Expression =
[#META]


Trend Expression =
IF(
    [#PRECO_KPI]
    ,SWITCH(
        TRUE()
        ,[#PRECO_YoY] <= -0.05, -2
        ,[#PRECO_YoY] < 0, -1
        ,[#PRECO_YoY] = 0, 0
        ,[#PRECO_YoY] >= 0.05, 2
        , 1
    )
)

--Status Arrow - Ascending


PRECO_%T_CLR = 
SWITCH (
    TRUE (),
    [PRECO_%T] <= -0.05, "#C0433A",
    [PRECO_%T] >= 0.05, "#79C75B",
    "#B2A424"
)