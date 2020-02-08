# CoronavirusAPI

КоронавирусАПИ позволяет получать данные о вирусе, такие как:
* Новости
* Количество зараженных, умерших и выздоровевших
* Города, страны
* Российские субъекты

## Установка

Используйте Nuget для установки

```https://www.nuget.org/packages/CoronavirusAPI/```



## Использование

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
