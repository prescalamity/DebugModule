# DebugModule
add debug code to the project

This project is for adding debug code to the target project. And reduces time for solving the bug of the target project.

The target project is C# project currently.

by Lugiyan in 2024/3/28


-------------------------------------------------------------------------------------------------------------------------------

目标：
1、根据日志快速读懂程序
2、好的日志要能 确保 程序高质量运行：（减少大量bug定位时间）

即：
1、好的日志 不能太消耗性能。                                       （性能消耗主要有，添加语句 循环执行，高频的io读写）
2、好的日志 能帮助开发人员，快速定位bug的原因。
3、有些高频，或 循环执行的函数要支持删除。               （方便查看日志）

策略：
快速定位所有可能的bug，必须要大量的日志，但为了降低设备性能的消耗，大量的日志必需有条件的特定开启。

实施：
将每个函数添加一条日志（参数中，基本数据类型，字符串，引用类型判空，等，类型参数的打印），
然后，在日志模块，增加超阈值IO缓存，和日志文件上报功能，以及 指定客户端日志缓存上报功能。










