# IELTS Calculator
![IELTS Calculator Demo](IeltsCalculate.gif)

**IELTS Calculator** — bu konsol dastur bo‘lib, foydalanuvchining IELTS imtihonidagi to‘rtta modul ballari (Listening, Reading, Writing, Speaking) asosida **Overall Band Score** ni hisoblab beradi.

---

## Xususiyatlari

- Konsol orqali foydalanuvchi ballarni kiritadi.
- Har bir modul bo‘yicha ballarni qabul qiladi: Listening, Reading, Writing, Speaking.
- IELTS qoidalariga muvofiq Overall Band Score ni hisoblaydi va 0.5 yoki 1 ga yaxlitlaydi.
- Natijani konsolda chiqaradi.

---

## Loyiha tarkibi
IELTS_calculate/
│
├─ Program.cs # Dastur ishga tushadigan fayl
├─ Process.cs # IELTS Overall hisoblash logikasi
└─ README.md # Loyihaning tavsifi

---

## Ishlatish

1. Kodni Visual Studio yoki boshqa C# muhiti orqali oching.
2. `Program.cs` faylini ishga tushiring.
3. Konsol oynasida quyidagi ballarni kiriting:
   - Listening
   - Reading
   - Writing
   - Speaking
4. Dastur sizga **Overall Band Score** ni chiqaradi.

---

## Misollar

| Listening | Reading | Writing | Speaking | Overall |
|-----------|---------|---------|----------|---------|
| 7         | 6.5     | 6.5     | 6.5      | 6.5     |
| 5.5       | 6       | 5       | 5.5      | 5.5     |
| 8         | 7.5     | 7.5     | 7        | 7.5     |
| 6.25      | 6.25    | 6.25    | 6.25     | 6.5     |
| 6.75      | 6.75    | 6.75    | 6.75     | 7.0     |

---

## Hisoblash formulasi

Overall Band Score quyidagicha hisoblanadi:

\[
\text{Overall} = \text{RoundToHalfOrWhole}\left(\frac{\text{Listening} + \text{Reading} + \text{Writing} + \text{Speaking}}{4}\right)
\]

- 0.25–0.75 orasidagi qiymatlar → 0.5 ga yaxlitlanadi  
- 0.75 dan yuqori → keyingi butun songa yaxlitlanadi

C# da hisoblash misoli:

```csharp
public double CalculateOverall(double listening, double reading, double writing, double speaking)
{
    double average = (listening + reading + writing + speaking) / 4.0;
    double overall = Math.Round(average * 2) / 2; // 0.5 ga yaxlitlash
    return overall;
}
