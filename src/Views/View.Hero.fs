module App.Views.Hero

open Fable.Helpers.React
open Fable.Helpers.React.Props


let hero model dispatch =
    div [ Class "hero"
          Style [ Background "url(./img/kandddinsky.jpg)"
                  BackgroundSize "cover"
                  BackgroundPosition "center" ] ]
      [ div [ Class "overlay" ] []
        div [ Class "hero-content" ]
          [ div [ Class "h-64"] []
            div [ Class "hero-text sm:text-3xl md:text-4xl xl:text-5xl w-full sm:w-3/4 mt-8 flex flex-col items-center justify-center" ]
              [ div [ Class "font-black" ]
                 [ str "Virtual Domain-Driven Design" ]                  
                div [ Class "text-xl font-medium" ] 
                  [ str "An online Domain-Driven Design meetup and conference." ] ] 
            div [ Class "h-64"] []   ] ] 