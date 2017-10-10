--[[
https://github.com/yongkangchen/poker-server

Copyright (C) 2016  Yongkang Chen lx1988cyk#gmail.com

GNU GENERAL PUBLIC LICENSE
   	Version 3, 29 June 2007

Copyright (C) 2007 Free Software Foundation, Inc. <http://fsf.org/>
Everyone is permitted to copy and distribute verbatim copies
of this license document, but changing it is not allowed.
--]]

require "global"

require "check_game"

local start = coroutine.wrap(function()
    local game_cfg = require "game_cfg"
    
    SocketManager.HOST = "localhost"
    SocketManager.PORT = 9999
    
    local player_data = require "login"()
    
    local get_room_data = require "lobby"(player_data)
    
    local game_play = require "game".play()
    
    while true do
        if not player_data.room_data then
            player_data.room_data = sync(get_room_data)()
        end
        sync(game_play)(player_data)
    end
end)

return {
    start = start,
}