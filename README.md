## Aplica��o de empr�stimos

Este projeto representa a implementa��o de uma aplica��o cujo prop�sito � determinar quais modalidades de empr�stimo uma pessoa tem acesso.
Ele foi desenvolvido seguindo as regras estabelecidas no reposit�rio de desafios do backend-br. 

Este reposit�rio oferece um conjunto espec�fico de crit�rios e requisitos que devem ser seguidos durante o desenvolvimento. Voc� pode consultar os detalhes clicando 
**[aqui](https://github.com/backend-br/desafios/blob/master/loans/PROBLEM.md)**.


## Exemplo

As modalidades de empr�stimo que ser�o analisadas s�o:

- **Empr�stimo pessoal**: Taxa de juros de 4%.
- **Empr�stimo consignado**: Taxa de juros de 2%.
- **Empr�stimo com garantia**: Taxa de juros de 3%.

As modalidades de empr�stimo dispon�veis para uma pessoa s�o baseadas em algumas vari�veis espec�ficas, s�o elas:

- **Idade**
- **Sal�rio**
- **Localiza��o**

### Requisitos

- Conceder o empr�stimo pessoal se o sal�rio do cliente for igual ou inferior a R$ 3000.
- Conceder o empr�stimo pessoal se o sal�rio do cliente estiver entre R$ 3000 e R$ 5000, se o cliente tiver menos de 30
  anos e residir em S�o Paulo (SP).
- Conceder o empr�stimo consignado se o sal�rio do cliente for igual ou superior a R$ 5000.
- Conceder o empr�stimo com garantia se o sal�rio do cliente for igual ou inferior a R$ 3000.
- Conceder o empr�stimo com garantia se o sal�rio do cliente estiver entre R$ 3000 e R$ 5000, se o cliente tiver
  menos de 30 anos e residir em S�o Paulo (SP).