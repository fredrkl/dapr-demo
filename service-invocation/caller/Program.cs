var client = new HttpClient();

for (int i = 1; i <= 100; i++)
{
  var response = await client.GetAsync($"https://jsonplaceholder.typicode.com/todos/{i}");

  if (response.IsSuccessStatusCode)
  {
    var content = await response.Content.ReadAsStringAsync();
    Console.WriteLine(content);
    Thread.Sleep(1000);
  }
  else
  {
    Console.WriteLine($"Request failed with status code {response.StatusCode}");
  }
}
