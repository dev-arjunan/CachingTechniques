# CachingTechniques

The goal of this tutorial is to explain you how to make use of HTTP cache and memory cache to  improve performance of web application.

**Use case :** MVC application uses SWAPI API service for getting user detail based on the user id. If user invokes  same request again, instead of pulling data from service, I am fetching data from memory.

I have used 2 different types of caching techniques.
 - HTTP context (System.Web)
 - Memory cache(System.RunTime.Caching)
