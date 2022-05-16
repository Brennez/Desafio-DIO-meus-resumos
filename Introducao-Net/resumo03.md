# Introdução ao pensamento computacional :man_scientist:

- ####  :spiral_notepad: Link notion: 

  - [Resumo 1](https://showy-secure-60e.notion.site/Ecossistema-Net-e-Documenta-o-a1d76d33fdb84b288e55a9dd79068c55)

- ####  :computer: Minhas redes:

  - [GitHub](https://github.com/Brennez)

  - [Linkedin](https://www.linkedin.com/in/tchalisson-brenne-27911421b/)

- ####  :paperclips: Resumo: 

- Slides das aulas:

  - Apresentação  → ([Apresentacao do Expert.pptx - Apresentações Google](https://docs.google.com/presentation/d/17_so96uxqkX2o_D9_6TzSUvP6aTvXlOf/edit#slide=id.p2))
  - Slide aula 01    →  ([Curso Introdução ao Ecossistema .NET - Aula 1.pptx - Apresentações Google](https://docs.google.com/presentation/d/1CxUS5QHCu4mqMiCoMqbMpGjUntIlpYSc/edit#slide=id.p5))
  - Slide aula 02    → ([Curso Introdução ao Ecossistema .NET - Aula 2.pptx - Apresentações Google](https://docs.google.com/presentation/d/1FvIKgAR2AAA5q6CWxiUYCRt3UI88OqMP/edit#slide=id.p5))
  - Slide aula 03 → [Curso Introdução ao Ecossistema .NET - Aula 3.pptx - Apresentações Google](https://docs.google.com/presentation/d/1Vhee732MMbZIELQEWDx1CSwVyNinyYN1/edit#slide=id.p5)
  - Slide aula 04 - ([Curso Introdução ao Ecossistema .NET - Aula 4.pptx - Apresentações Google](https://docs.google.com/presentation/d/1f99uXpF7vx12B1-RXewflQ_kZzc32mk-/edit#slide=id.p5))
  - Slide aula 05 - ([Curso Introdução ao Ecossistema .NET - Aula 5.pptx - Apresentações Google](https://docs.google.com/presentation/d/16n61iXir2ywb-DW72H_Zjr7raqOjw_Ia/edit#slide=id.p5))
  - Resumo aula 03

- Padrões de codificação

  - O que um bom código dever ser?

    - Confiável
    - Sustentável
    - Eficiente

  - Por que é importante padronizar?

    - Melhora a comunicação entre a equipe
    - Auxilia a manutenção

  - Clean code:

    - Conjuntos de boas práticas que melhoram a legibilidade do código, bem como a manutenibilidade do código no futuro

  - Regras gerais, clean code:

    - Seguir sempre as convenções da equipe
    - Mantenha o código estupidamente simples
    - Devolva o código mais limpo do que encontrou
    - Buscar entender e solucionar os problemas a partir de sua raiz

  - Regras de nomeação

    - Escolha nomes descritivos para variáveis, métodos e classes

    - Faça uma distinção clara entre variáveis semelhantes

    - Utilize nomes de fácil leitura e busca

    - Utilize constantes para guardar strings que serão comparadas

      - Exemplo:

        ```jsx
        //evite 
        if(enviroment == "PROD")
        
        //utilize 
        const string ENV = "PROD"
        if(enviroment == ENV)
        ```

    - Não usar prefixos ou caracteres especiais

    - Métodos não devem ser longos e devem possuir apenas um objetivo/responsabilidade

    - Não usar muitos parâmetros

    - Evite fazer com que métodos alterem valores de outra classe, sem ser o da sua própria classe

    - Não utilize flags desnecessárias

  - Regras para comentários

    - Não use comentários desnecessários
    - Não use comentários redundantes
    - Não comente código não utilizado
    - Use para explanar sobre regras complexas e alerta de consequências sérias

  - Convenção de escrita

    - camelCase → Primeira letra minúscula as demais maiúsculas
    - PascalCase → Primeira letra maiúsculas as demais maiúsculas
