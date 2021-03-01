# 建造者設計模式 (Builder Design Pattern)

**種類: 創建型模式(Creational Pattern)**

### Pros
1. 可以透過方法來設定屬性，也可針對設定的值進行檢查，而針對沒有用到的屬性可以跳過或給予預設值。
2. 在生成物件或設定屬性的時候為 Thread-Safe。

### Cons
1. 要多寫很多程式碼。
2. 嘗試生成物件的時候，要從生成物件，變成如何建構出一個物件。

### When to use?
1. 在建構子參數過多的情況下，為了解決 Telescoping Constructor(Constructor 互相呼叫)
2. 類似抽象工廠，但可以想成是應用於抽象工廠之上的概念，透過抽象工廠的實作與 Variadic Parameters，建構出更大的組合。

### Reference
[The Builder Design Pattern](https://www.bradcypert.com/design-patterns-builder/)

[設計模式—建造者模式 (Builder Design Pattern)](https://medium.com/wenchin-rolls-around/%E8%A8%AD%E8%A8%88%E6%A8%A1%E5%BC%8F-%E5%BB%BA%E9%80%A0%E8%80%85%E6%A8%A1%E5%BC%8F-builder-design-pattern-7c8eac7c9a7)

[Design Pattern(10) - Builder](https://www.jyt0532.com/2017/06/29/builder/)