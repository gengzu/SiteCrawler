@echo Let's start

@echo Start Web Server

start dnx -p src/Crawler.Web web

@echo Start Service 1

start dnx -p src/Crawler.Service run

@echo Start Service 2

start dnx -p src/Crawler.Service run