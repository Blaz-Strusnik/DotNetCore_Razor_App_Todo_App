https://www.yogihosting.com/aspnet-core-identity-setup/

Ne pozabi na connection string v aosettings.json in NE POZABI VKLOPITI SQL SERVERJA

Scaffold Identity into an MVC project without existing authorization LINK :

https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-6.0&tabs=netcore-cli

Po tem postopku moraš v DOTNET CLI dodati migracije in posodobiti podtkovno bazo:
dotnet ef migrations add CreateIdentitySchema_2 --context Upravljalec_NalogContext
dotnet ef database update --context Upravljalec_NalogContext

--V MSSAL SERVERJU STA ZA APILIKACIJJO UPRAVLJALEC NALOG DVE PODTKOVNI BAZI
--PODATKOVNI BAZI NALOGE SO SHRANJENE SAMO NALOGE
--v PODATKOVNI BAZI UPRAVLJALEC_NALOG SO SHRANJENI ASP_NET_USERS OZIROMA UPORABNIKI

Po končanem scaffoldanju nastive še stvari ki so v tem posnetku LINK :
https://www.youtube.com/watch?v=CzRM-hOe35o

P