## Treinando MVC

Este projeto foi versionado já com alterações, é um dos meus primeiros contatos com o design arquitetural MVC. Posssui algumas classes e pastas que foram adicionadas depois da criação do template do **ASP.NET Core MVC**.

Pastas:
- Data  
pasta criada para adicionar uma camada de dados na aplicação. O provider utilizado como Dbcontext é do SQL Server.

- Migrations  
Pasta utilizada pelo Entity Framework. nela são adicionadas as migrations, que facilitam o trabalaho na hora de criar a base de dados

- Repository  
Camada de comunicação com a base de dados. Design pattern onde as classes contém os métodos de interação com a base de dados, para evitar coloca-los na classe da pasta "Model". Ex: Cliente(Pasta Model) --> ClienteRepository(Pasta Repository)
