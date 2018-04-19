--[[
https://github.com/yongkangchen/lua-await

MIT License

Copyright (c) 2016 Yongkang Chen lx1988cyk#gmail.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
]]
return function(func)
    return function(...)
        local co
        local ret
        local called = false
        
        local arg = {...}
        local len = select("#", ...) + 1
        arg[len] = function(...)
            -- 调用恢复
            assert(called == false)
            called = true
            if co == nil then
                ret = {...}
            else
                local resume_co = co
                co = nil
                coroutine.resume(resume_co, ...)
            end
        end

        -- 参数加长
        func(unpack(arg, 1, len))

        if ret then
            return unpack(ret)
        end
        
        co = coroutine.running()
        return coroutine.yield()
    end
end