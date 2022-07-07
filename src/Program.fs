module Program

[<EntryPoint>]
let main argv =
    let game = new Game.GameCore()
    do game.Run()
    0