module Game

open System.IO
open System
open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics
open Microsoft.Xna.Framework.Input

type GameCore() as this =
    inherit Game()

    // let mutable input = Unchecked.defaultof<Input.State>
    // let mutable gameCOntent = Unchecked.defaultof<Sample.Content>

    let gdm = new GraphicsDeviceManager(this)

    do gdm.GraphicsProfile <- GraphicsProfile.HiDef
    do gdm.PreferredBackBufferWidth <- 1280
    do gdm.PreferredBackBufferHeight <- 720
    do gdm.IsFullScreen <- false

    do gdm.ApplyChanges()
    do base.Content.RootDirectory <- "content"

    //let updateInputState() =
    //    input <- Keyboard.GetState() |> Input.updated input

    override this.Initialize() =
        base.Initialize()

    override this.LoadContent() = 
        //input <- Input.initialState()
        // gameContent <-
        base.LoadContent()


    override this.Update(gameTime) =
        // updateInputState()
        // if Input.justPressed input Keys.Escape then _this.Exit()
        base.Update(gameTime)
    
    override this.Draw(gameTime) =
        this.GraphicsDevice.Clear(Color.CornflowerBlue)
        base.Draw(gameTime)