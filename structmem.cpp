#include <iostream>
#include <memory>
#include <vector>

auto print_int(int i) -> void {
    std::cout << i << "\n";
}

struct Seq {
    int id;
    std::shared_ptr<std::vector<int>> vals;
};

auto upped_id(Seq seq) -> Seq {
    seq.id += 1;
    return seq;
}

auto report_changes(Seq a) -> void {
    auto b = upped_id(a);
    print_int(a.id);
    print_int(b.id);
}

auto main() -> int {
    auto a = Seq {
        .id = 5,
        .vals = std::make_shared<std::vector<int>>(std::vector { 6, 7 }),
    };
    report_changes(a);
}
