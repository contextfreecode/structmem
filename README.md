[Godbolt disassembly](https://godbolt.org/z/br78E8hx8)

Some commands:

```
time dotnet run
time { g++ structmem.cpp -o structmem && ./structmem; }
time { g++ structmem.cpp -o structmem && valgrind ./structmem; }
time cargo run
```
