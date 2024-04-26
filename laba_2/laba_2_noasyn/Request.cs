namespace laba_2_noasyn
{
    class Request
    {
        public string Get(HttpClient httpClient, string job)
        {

            HttpResponseMessage response = httpClient.GetAsync(job).Result;
        
            var jsonResponse = response.Content.ReadAsStringAsync().Result;
            
            return jsonResponse;

        }
    }
}