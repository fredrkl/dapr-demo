var client = new HttpClient();
var response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/1");

if (response.IsSuccessStatusCode)
{
  var content = await response.Content.ReadAsStringAsync();
  Console.WriteLine(content);
}
else
{
  Console.WriteLine($"Request failed with status code {response.StatusCode}");
}
