
SELECT 
PRODUTOS.NOME_PROD ,  
CORES.NOME_COR , 
sum(CASE WHEN CORES.PRC_COR IS NOT NULL 
THEN  (PRODUTOS.PRC_PROD + CORES.PRC_COR) 
ELSE PRODUTOS.PRC_PROD  END)  as PRECO_PRODUTO,
sum(CASE WHEN CORES.PRC_COR IS NOT NULL 
THEN  ((PRODUTOS.PRC_PROD + CORES.PRC_COR) + ((PRODUTOS.PRC_PROD + CORES.PRC_COR)/10))
ELSE(PRODUTOS.PRC_PROD + (PRODUTOS.PRC_PROD/10) ) END) as PRECO_ACRESCIMO ,
sum(CASE WHEN CORES.PRC_COR IS NOT NULL 
THEN  ((PRODUTOS.PRC_PROD + CORES.PRC_COR) - ((PRODUTOS.PRC_PROD + CORES.PRC_COR)/10)) 
ELSE(PRODUTOS.PRC_PROD - (PRODUTOS.PRC_PROD/10) ) END) as PRECO_DESCONTO
FROM PRODUTOS LEFT JOIN CORES 
ON PRODUTOS.IDPRODUTO = CORES.ID_PRODUTO
WHERE Produtos.NOME_PROD IS NOT NULL
GROUP BY PRODUTOS.NOME_PROD, CORES.NOME_COR
ORDER BY PRECO_PRODUTO ASC