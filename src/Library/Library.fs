module Library

open Newtonsoft.Json

let getJsonNetJson value = 
    let json = JsonConvert.SerializeObject(value)
    $"I used to be {value} but now i'm {json} thanks to JSON.NET!"