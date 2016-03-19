@echo Restore Service

call dnu restore src/Crawler.Service

@echo Build WebService

call dnu build src/Crawler.Service

@echo Restore WebSite

call dnu restore src/Crawler.Web

@echo Build WebSite

call dnu build src/Crawler.Web
