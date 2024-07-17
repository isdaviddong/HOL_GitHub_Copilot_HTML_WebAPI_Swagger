using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/bmi")]
public class MyController : ControllerBase
{
    //支援post方法，可傳入身高體重，計算bmi的api
    [HttpPost]
    public IActionResult Post([FromBody] BmiModel model)
    {
        var bmi = model.Weight / Math.Pow(model.Height / 100, 2);
        return Ok(bmi);
    }
    
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello, World!");
    }
}

//建立 BmiModel 類別
public class BmiModel
{
    public double Height { get; set; }
    public double Weight { get; set; }
}