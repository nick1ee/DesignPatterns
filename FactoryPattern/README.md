# 工廠設計模式 (Factory Design Pattern)

**種類: 創建型模式(Creational Pattern)**

### Pros
1. 讓程式碼之間不再有強相依，多了一層可以動態調整相依 Class 的的機會。
2. 如果生成相關聯的產品，需要傳入不同的參數，那這種寫法也可以避免參數統一寫在使用端，而是由各自的 Factory 自己控制。

### Cons
1. 會多寫很多 Class，在程式碼的追蹤上會提高難度，容易迷路。

### Three Patterns

**1. Simple Factory Pattern**
為了避免對於 Class 之間的強相依，因此透過生成 Class 的這個行為，統一在工廠內去做執行。
而對使用者來說，僅須在工廠生產的時候，傳入不同的參數，即可決定要生成不同類型的物件來做使用。

**2. Factory Method**
將工廠模式的生成方法宣告成 Interface，而非直接寫死在統一的 Factory 中。
由實作該 Interface 的 Concrete Class 來決定此 Factory Method 該如何實作，如此即可將工廠模式延遲到 sub-class 中再做決定生成。
而每個 Factory 只要有遵從該 Interface 就可以專注在生產自己的產品身上，未來如果有需要新增產品，也僅需新增自己的 Factory 而不用修改到既有程式碼。

**3. Abstract Factory**
讓多個工廠可以生產一系列類似的產品。

### When to use?
1. 很多類似的物件，而且生成的方法大同小異，此時就可以將這一系列的產品，包成 Factory 當中來做處理。
2. 生成物件需要額外傳入許多參數來做判斷，而這些參數可能不是使用端 Class 所需要知道的，此時也適合將邏輯抽進 Factory 當中來做收整。

### Reference
[工廠設計模式 (Factory Design Pattern)](https://carsonwah.github.io/factory-design-pattern.html)

[Design Patterns: Abstract Factory vs Factory Method](https://stackoverflow.com/questions/4209791/design-patterns-abstract-factory-vs-factory-method/4211307#4211307)