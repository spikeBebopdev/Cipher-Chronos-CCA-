
#
## Cipher Chronos (CCA) - Documentação
#

Descrição:
-----------
A Cipher Chronos (CCA) é um método de criptografia avançado que combina algoritmos de ordenação personalizados, 
transformações matemáticas aleatórias e uma estrutura de ordenação circular. Essa combinação cria uma criptografia 
altamente complexa e resistente a ataques, tornando o processo de descriptografia praticamente impossível sem o 
conhecimento do algoritmo completo.

Etapas da Criptografia:
-----------------------

1. **Ordenação Personalizada**
   - O texto é separado em três grupos: letras, números e símbolos.
   - Cada grupo é ordenado individualmente.
   - Os grupos são então concatenados na ordem: letras, números e símbolos.

2. **Funções Matemáticas Aleatórias (2º ao 4º Grau)**
   - Cada caractere é convertido em seu valor ASCII.
   - Funções polinomiais aleatórias de 2º a 4º grau são aplicadas a cada valor.

3. **Reordenação pela Soma dos Dígitos**
   - Os números resultantes das funções matemáticas são reorganizados com base na soma de seus dígitos.

4. **Ordenação Circular com Saltos**
   - Os números reorganizados são dispostos em formato circular.
   - Um padrão de saltos (ex: 2, 3, 1, 4) é usado para percorrer o círculo, criando a criptografia final.

Exemplo de Funcionamento:
-------------------------

Texto Original: B4a#9d!

1. **Ordenação Personalizada:** Bad49!#
2. **Funções Matemáticas:** [8911, 912673, ...]
3. **Reordenação:** [8911, 912673, ...]
4. **Ordenação Circular:** 8911-912673-...

Resultado Criptografado: 8911-912673-12345-67890

Segurança:
----------
- A complexidade é garantida pelo uso de funções aleatórias e ordenações dinâmicas.
- Sem a chave (funções matemáticas, critério de ordenação e sequência de saltos), a descriptografia é inviável.

Descriptografia:
----------------
- Reverter o processo exige o conhecimento de todas as etapas e parâmetros usados durante a criptografia.

##
Criado por: spikeBebopdev

Data: 2025

Licença: MIT

#
