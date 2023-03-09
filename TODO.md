# Todo list 

## Hunger 🍖

- [x] Add hunger
- [x] Add hunger display
- [x] Add hunger drain
    - [x] For moving
    - [x] For attacking
    - [x] For mining
- [x] Add hunger regen for food items
- [ ] Draw and add hunger bar ui
    - [ ] Sprite
    - [ ] Bar with hunger value
- [ ] Add negative effects when hungry
    - [ ] Slowness
    - [ ] Weakness
    - [ ] Mining fatigue (sometimes tile breaking doesn't work :)
    - [ ] Combat fatigue (sometimes you don't deal damage)
    - [ ] Nausea 
    - [ ] Blurry vision  
    - [ ] Hunger player effects
      - [ ] Shader effects :) 
    - [ ] Hunger sound
    - [ ] Death
- [ ] Add positive effects when full
    - [ ] Speed
    - [ ] Strength
    - [ ] Mining speed
    - [ ] Combat speed

## Thirst 💦

- [x] Add thirst
- [x] Add thirst display
- [x] Add thirst drain
    - [x] For being in biomes
    - [x] For using potions
    - [ ] For moving? (idk if this is needed)
- [x] Add thirst regen for drink items
- [ ] Draw and add thirst bar ui
    - [ ] Sprite
    - [ ] Bar with thirst value
- [ ] Add negative effects when thirsty
    - [ ] Slowness
    - [ ] Weakness
    - [ ] Blurry vision
    - [ ] Thirst player effects
      - [ ] Shader effects :) 
    - [ ] Death
- [ ] Add thirst based on temperature
- [ ] Add positive effects when not thirsty 


## Temperature 🌡️

- [x] Add env temperature
- [x] Add player temperature
- [x] Add humidity
- [x] Add temperature display
- [ ] Add temperature changes
    - [ ] For being in hot and cold biomes
      - [x] For player
        - [ ] Adjust the formula
      - [ ] For env
        - [ ] Gradual change of temperature based on Y position
        - [x] At least working
    - [ ] For using potions
    - [ ] For being in water
    - [x] For being in lava
      - [x] Add temperature change for being lavawet
    - [ ] For being in fire
    - [ ] For standing near hot things
      - [x] For standing near lava
      - [ ] For standing near fire
      - [ ] For standing near hot blocks
      - [ ] For standing near furnaces
      - [ ] For standing near campfires
    - [ ] For holding cold and hot things
    - [x] Wind temperature changes
- [ ] Add temperature based on thirst
- [x] Add temperature based on humidity
- [ ] Add temperature based on weather
  - [x] On rain
    - [ ] Make it better
    - [ ] Add humidity based on rain intensity
    - [ ] Add check if player is under rain
    - [x] Add humidity on rain
  - [x] On snow
  - [x] On sandstorm
  - [x] On eclipse
  - [x] On blood moon
  - [x] On snow moon
- [ ] Add windchill
- [ ] Add temperature based on time of day
  - [ ] Gradual change of temperature during day
  - [x] At least working
- [ ] Wet clothes ????
- [ ] Player wet after being in water
- [ ] Draw and add temperature bar ui
     - [ ] Sprite
     - [ ] Bar with temperature value
     - [ ] Items for showing temperature
- [ ] Add negative effects when too hot or too cold
    - [ ] Shiver
    - [ ] Sweating
    - [ ] Hypothermia
    - [ ] Heat stroke
    - [ ] Blurry vision
    - [ ] Temperature player effects
      - [ ] Shader effects :)
      - [ ] Sweating 
      - [ ] Shivering
      - [ ] Becoming more red (?)
      - [ ] Becoming more blue (?)
    - [ ] Death


## World changes 🌍
- [ ] Corruption giant spikes
- [ ] Crimson giant teeth
- [ ] Snow biome glaciers/flying islands (?)
- [ ] Hell biome lava geysers (like calamity death mode :)
- [ ] Lightning strikes when raining


## Items 🧸
- [ ] Add unique effects for all food items and drinks
  - [x] Add effects for drinks
- [ ] Change armor items to reflect temperature
- [ ] Change accessories to reflect temperature
- [ ] Add new items for new mechanics (idk what yet)

--- 

## Other 📝
- [ ] Add sprites 
- [ ] Add sounds
- [ ] Add shaders
- [ ] Refactor code
  - [ ] Divide IChange interface into smaller ones
  - [ ] IChange methods to be overridable
- [ ] Balance mechanics
- [ ] Add config
- [ ] Add localization
- [ ] Add mini-wiki
- [ ] Release first version of mod :)

## Issues 🪲
- [ ] Add saving and loading player stats
- [ ] Investigate body temperature formula (lava billion deg in caves)