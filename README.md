<p align="center">
<img alt="GitHub Issues" src="https://img.shields.io/github/issues/Juv1e/CoronavirusAPI">
<img alt="GitHub Stars" src="https://img.shields.io/github/stars/Juv1e/CoronavirusAPI">
<img alt="GitHub Forks" src="https://img.shields.io/github/forks/Juv1e/CoronavirusAPI">
</p>

# CoronavirusAPI

КоронавирусАПИ позволяет получать данные о вирусе, такие как:
* Новости
* Количество зараженных, умерших и выздоровевших
* Города, страны
* Российские субъекты

## Установка

Используйте Nuget для установки

```https://www.nuget.org/packages/CoronavirusAPI/```



## Пример

```csharp
using Coronavirus;

string News = Coronavirus.Methods.getNews.News(); // вернет все новости (parsed)
JObject jsonNews = Coronavirus.JsonData.News(); // вернет все новости (json)

```

## Доступные методы
На данный момент доступны методы: 
* getCountries
* getNews
* getRussianSubjects
* getStats
* getCities
