using Demo;

var request = new CreateGatewayRequest
{
    Amount = 1000,
    Currency = "CHF",
};

var gatewayFactory = new GatewayFactory(instance:"set-your-instance-name-here", apiKey:"set_your_api_key_here");

var gatewayResponse = gatewayFactory.CreateGateway(request);
Console.WriteLine(gatewayResponse);