// Task 1

function F(num) {
    const res = 9 / 5 * num + 32;
    return res.toFixed(1);
}

const C = Number.parseFloat(prompt("Введите температуру в градусах Цельсия"));
F(C);
alert(`Цельсий: ${C}, Фаренгейт: ${F(C)}`);