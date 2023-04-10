# Notice


## 기타 참고 사항

### Entity Framework Migration

```
Add-Migration AddName -Context ApplicationDbContext -Project AE.Notice.Common -StartupProject AE.Notice.WebApp -OutputDir Infrastructure\Persistence\Migrations
Remove-Migration -Context ApplicationDbContext -Project AE.Notice.Common -StartupProject AE.Notice.WebApp
Update-Database -Context ApplicationDbContext -Project AE.Notice.Common -StartupProject AE.Notice.WebApp
Update-Database RollbackName -Context ApplicationDbContext -Project AE.Notice.Common -StartupProject AE.Notice.WebApp
Script-Migration Name(이전항목)
```

### [ASP.NET Core에서 Identity 소개](https://learn.microsoft.com/ko-kr/aspnet/core/security/authentication/identity?view=aspnetcore-7.0&tabs=visual-studio)



### Docker

[Docker Compose를 사용하여 다중 컨테이너 앱 만들기](https://learn.microsoft.com/ko-kr/visualstudio/containers/tutorial-multicontainer?view=vs-2022)

```
docker-compose build
docker-compose up
docker-compose donw
```