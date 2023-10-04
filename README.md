# Using CoinBase API to get exchange rates
This C# code is used to connect to an API and parse the JSON response. The code uses the following libraries:

* System: This library provides basic types and functionality for C# applications.
* System.Collections: This library provides collection classes, such as lists, dictionaries, and queues.
* System.Collections.Generic: This library provides generic collection classes, which are more efficient and flexible than the non-generic collection classes.
* System.IO: This library provides classes for reading and writing files and streams.
* System.Net.Http: This library provides classes for making HTTP requests.
* Newtonsoft.Json.Linq: This library provides classes for parsing and manipulating JSON data.
* System.Text: This library provides classes for working with text data.
* System.Xml.Linq: This library provides classes for parsing and manipulating XML data.
* Newtonsoft.Json: This library provides classes for serializing and deserializing JSON data.

The code works as follows:

1. It creates a new HttpClient object.
2. It sets the DefaultRequestHeaders property of the HttpClient object to clear any existing headers. This is necessary because the API does not require any credential keys.
3. It makes a GET request to the API endpoint using the HttpClient object.
4. It reads the response from the API and saves it in a variable.
5. It parses the JSON response using the JObject class.
6. It displays the parsed JSON response and the status of the connection to the console.

The code can be modified to connect to any API and parse the JSON response. To do this, you would need to change the url variable to the endpoint of the API you want to connect to, and you would need to modify the parsing code to match the structure of the JSON response.

This code is so simple and is used just to know how to do API connections. Feel free to folk/clone the code and modify.
