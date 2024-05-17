Links:

- [Godbolt disassembly](https://godbolt.org/z/br78E8hx8)
- [Benchmarking and further analysis by Matheus C. França](https://gist.github.com/kassane/aee0f7e6dd6b9d1d56b0fe7057ba99d4)

Some commands:

```
time dotnet run
time { g++ structmem.cpp -o structmem && ./structmem; }
time { g++ structmem.cpp -o structmem && valgrind ./structmem; }
time cargo run
```
