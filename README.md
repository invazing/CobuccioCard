# XYZ Administradora de Cartões de Crédito

Sistema para cadastro e gerenciamento de transações de cartão de crédito, desenvolvido em VB.NET com SQL Server.

## Contexto

A XYZ Administradora de Cartões de Crédito busca uma solução robusta para gerenciar transações financeiras de clientes, garantindo eficiência, escalabilidade e confiabilidade no processamento de grandes volumes de dados.

## Funcionalidades

- **CRUD de Transações**  
  - Cadastro, edição (exceto transações aprovadas), exclusão (com confirmação) e consulta de transações.
  - Campos obrigatórios:  
    - Id_Transacao (automático)  
    - Numero_Cartao (16 dígitos)  
    - Valor_Transacao (decimal positivo)  
    - Data_Transacao (data/hora)  
    - Descricao (até 255 caracteres)  
    - Status_Transacao (Aprovada, Pendente, Cancelada)
  - Filtros de consulta: Número do cartão, data, valor, status.
  - Exibição em DataGrid com paginação eficiente.

- **Tratamento de Erros e Logs**  
  - Mensagens amigáveis ao usuário.
  - Registro detalhado de erros em arquivo de log.

- **SQL Server**  
  - Stored Procedure para totalização de transações por período e status.
  - Scalar Function para categorização de valores.
  - Table-Valued Function (TVF) para listar transações categorizadas.
  - View consolidada para consultas financeiras.

- **Exportação para Excel**  
  - Exporta transações do último mês para arquivo Excel.

## Requisitos

- Visual Studio 2022
- .NET Framework 4.7.2 ou superior
- SQL Server 2016 ou superior

## Instalação e Execução

1. **Clone o repositório:**

git clone https://github.com/seu-usuario/seu-repositorio.git


2. **Configure o banco de dados:**
   - Execute o script `ScriptSQL.sql` para criar tabelas, procedures, functions, views e inserir dados de exemplo.

3. **Ajuste a string de conexão:**
   - No arquivo de configuração da aplicação (`App.config` ou equivalente), ajuste a string de conexão para o seu SQL Server.

4. **Abra o projeto no Visual Studio 2022 e execute.**

## Estrutura do Projeto

- `/Forms` - Telas da aplicação (CRUD, login, consulta, etc)
- `/Shared` - Utilitários e helpers (ex: log de erros)
- `/SQL` - Scripts SQL (tabelas, procedures, functions, views)
- `/Relatorios` - Exemplo de relatório Excel gerado

## Exemplo de Uso

1. Cadastre, edite e exclua transações conforme as regras de negócio.
2. Consulte transações com filtros e exporte para Excel.
3. Consulte relatórios financeiros via views e TVFs no SQL Server.

## Licença

Este projeto é apenas para fins de avaliação técnica.
   
