# Notice


## ��Ÿ ���� ����

### Entity Framework Migration

```
Add-Migration AddName -Context ApplicationDbContext -Project AE.Notice.Common -StartupProject AE.Notice.WebApp -OutputDir Infrastructure\Persistence\Migrations
Remove-Migration -Context ApplicationDbContext -Project AE.Notice.Common -StartupProject AE.Notice.WebApp
Update-Database -Context ApplicationDbContext -Project AE.Notice.Common -StartupProject AE.Notice.WebApp
Update-Database RollbackName -Context ApplicationDbContext -Project AE.Notice.Common -StartupProject AE.Notice.WebApp
Script-Migration Name(�����׸�)
```

### [ASP.NET Core���� Identity �Ұ�](https://learn.microsoft.com/ko-kr/aspnet/core/security/authentication/identity?view=aspnetcore-7.0&tabs=visual-studio)



### Docker

[Docker Compose�� ����Ͽ� ���� �����̳� �� �����](https://learn.microsoft.com/ko-kr/visualstudio/containers/tutorial-multicontainer?view=vs-2022)

```
docker-compose build
docker-compose up
docker-compose donw
```