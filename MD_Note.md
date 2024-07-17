# 大标题
## 二级标题
### 三级标题

## 导航
-   [表格](#表格)
-   [代码](#代码)
-   [强调](#01)
-   [列表](#02)

##  段落
这是第一行

这是第二行

水平线
***
---
___

##  引用
> 这是引用的内容
>> 这是引用的引用

##  图片
在github中打开图片，复制url地址例如：`https://github.com/ErikSao/ATE/blob/main/PAHost/PAHost/Resources/images/GC.ico`

将其替换为`https://raw.githubusercontent.com/ErikSao/ATE/main/PAHost/PAHost/Resources/images/GC.ico`

![图片描述](https://raw.githubusercontent.com/ErikSao/ATE/main/PAHost/PAHost/Resources/images/GC.ico)

![图片描述](https://raw.githubusercontent.com/ErikSao/ATE/main/PAHost/PAHost/Resources/images/Snipaste_2024-07-16_15-43-52.png)


## 徽章
在[Shields.io](https://shields.io/)中制作。

例如：

![GitHub](https://img.shields.io/github/license/ErikSao/ATE)

[![GitHub](https://img.shields.io/github/license/ErikSao/ATE)](https://github.com/ErikSao/ATE/blob/main/LICENSE)

[![GitHub](https://img.shields.io/github/stars/ErikSao/ATE)](https://github.com/ErikSao/ATE/stargazers)

[![GitHub](https://img.shields.io/github/issues/ErikSao/ATE)](https://github.com/ErikSao/ATE/issues)

[![GitHub](https://img.shields.io/github/issues-pr/ErikSao/ATE)](https://github.com/ErikSao/ATE/pulls)

[![GitHub](https://img.shields.io/github/repo-size/ErikSao/ATE)](https://github.com/ErikSao/ATE/archive/refs/heads/main.zip)

格式为：`https://img.shields.io/github/{io}/{owner}/{repo}`

其中`https://github.com/ErikSao/ATE`为仓库地址，`repo`为仓库名称,`owner`为GitHub用户名,`io`为徽章类型

##  数学公式
行内公式：$a^2+b^2=c^2$

行间公式：

$$
a^2+b^2=c^2
$$

##  链接
[链接描述](https://github.com/ErikSao)

##  代码
单行代码

`
_lstHandlers.AddLast(new SantakUPSQueryHandler(this, "Q6"));      
`

多行代码

```
public static ushort CalculateCRC(byte[] addr)
{
    ushort crc = 0xFFFF;
    for (int i = 0; i < addr.Length; i++)
    {
        crc ^= addr[i];
        for (int j = 0; j < 8; j++)
        {
            if ((crc & 1) != 0)
            {
                crc >>= 1;
                crc ^= 0xA001;
            }
            else
            {
                crc >>= 1;
            }
        }
    }
    return crc;
}
```

##  表格
| 表头1 | 表头2 |
|------|------|
| 内容1 | 内容2 |
| 内容3 | 内容4 |

##  <span id="01">强调</span>
*斜体* _斜体_

**粗体** __粗体__

~~删除线~~

要`突出`显示

##  <span id="02">列表</span>
-   列表前加点
+   列表标记
-   列表标记
    -   列表标记
    -   列表标记
        -   列表标记
            -   列表标记


## 任务列表
-   [ ] 未完成的任务
-   [x] 已完成的任务


## 脚注
这是一个脚注[^1]。

[^1]:脚注内容。

## 转义字符
\*特殊字符\*

*特殊字符*

## 行内HTML

<u>下划线文本<u>