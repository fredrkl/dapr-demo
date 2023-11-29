var client = new HttpClient();

for (int i = 1; i <= 100; i++)
{
  var response = await client.GetAsync($"https://jsonplaceholder.typicode.com/todos/{i}");

  if (response.IsSuccessStatusCode)
  {
    var content = await response.Content.ReadAsStringAsync();
    Console.WriteLine(content);
  }
  else
  {
    Console.WriteLine($"Request failed with status code {response.StatusCode}");
  }
  Thread.Sleep(2000);
}
