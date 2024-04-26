namespace laba_2_asyn
{
    class Request
    {
        public async Task<string> Get(HttpClient httpClient, string job)
        {

            HttpResponseMessage response = await httpClient.GetAsync(job);
            
            var jsonResponse = await response.Content.ReadAsStringAsync();
            
            return jsonResponse;

        }
    }
}