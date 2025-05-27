# 💳 CobuccioCard - Grupo Adriano Cobuccio

Sistema completo para **cadastro e gerenciamento de transações de cartão de crédito**, desenvolvido em **VB.NET** com **SQL Server**.  
Focado em **eficiência, confiabilidade** e **escalabilidade** no processamento de dados financeiros.

---

## 📘 Visão Geral

A Grupo Adriano Cobuccio precisava de uma solução robusta para o controle de transações financeiras dos clientes.  
Este sistema foi desenvolvido para atender com segurança, organização e boa performance.

---

## ⚙️ Funcionalidades Principais

### ✅ CRUD de Transações
- Cadastrar, consultar, editar (exceto transações aprovadas) e excluir transações.
- Validação dos campos:
  - `Id_Transacao` (gerado automaticamente)
  - `Numero_Cartao` (16 dígitos)
  - `Valor_Transacao` (decimal positivo)
  - `Data_Transacao` (data/hora)
  - `Descricao` (até 255 caracteres)
  - `Status_Transacao` (Aprovada, Pendente, Cancelada)
- Filtros: número do cartão, data, valor, status.
- Exibição em `DataGrid` com paginação otimizada.

### 🛡️ Tratamento de Erros e Logs
- Exibição de mensagens amigáveis ao usuário.
- Log detalhado de exceções salvo em arquivos `.log` na pasta %programdata%/Cobucciocard/cobucciocard.log.

### 🗃️ SQL Server Avançado
- `Stored Procedure`: totalização de transações por período e status.
- `Scalar Function`: categorização de valores.
- `Table-Valued Function (TVF)`: listagem de transações com categorias.
- `View`: consolidação de dados para relatórios.

### 📤 Exportação para Excel
- Exporta transações do período selecionado para arquivo Excel (.xlsx).

---

## 🧩 Requisitos

- Visual Studio 2022  
- .NET Core 8.0 ou superior  
- SQL Server 2016 ou superior

---

## 🚀 Como Executar

### 1. Clone o repositório

```bash
git clone https://github.com/seu-usuario/seu-repositorio.git
```

### 2. Configure o banco de dados
Execute o script SQL/ScriptSQL.sql para criar:

- Tabelas
- Stored Procedures
- Functions
- Views

## Dados de exemplo

### 3. Ajuste a string de conexão
No arquivo App.config, configure a string de conexão com seu SQL Server.

### 4. Execute o projeto
Abra a solução no Visual Studio 2022.

Compile e inicie a aplicação (F5).

📁 Estrutura do Projeto
plaintext
Copy
Edit
- /Forms        → Telas (CRUD, login, consultas)
- /Shared       → Utilitários e helpers (ex: log de erros)
- /SQL          → Scripts SQL do sistema
- /Relatorios   → Exemplos de relatórios gerados

## 🧪 Exemplo de Uso
Cadastre e consulte transações com filtros específicos.

Exporte dados para Excel com um clique.

Acesse relatórios financeiros via views e TVFs no SQL Server.

📄 Licença
Este projeto foi desenvolvido exclusivamente para avaliação técnica.
Distribuição comercial ou uso externo não são permitidos.

---

Se quiser, posso te mandar isso já formatado como arquivo `README.md` ou `.txt`. É só avisar!
