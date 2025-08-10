
# 🎒 Late for School

**Late for School**, Unity ile geliştirilmiş, **sonsuz koşu (endless runner)** türünde eğlenceli bir okul macerasıdır.  
Kahramanımız uyuyakaldı ve **okula yetişmek için** sokaklarda hızla koşmak zorunda!  
Yolda **kahve booster’ları**, **enerji içecekleri** ve diğer güçlendirmeler toplayarak hızını artırabilir.  
Engellerden kaç, puan topla ve okula zamanında varmaya çalış!

🎮 Oynanış
Amaç: Okula geç kalmadan koşmak ve en yüksek skoru elde etmek

Kontroller:

⬅️ Sol Ok – Sola hareket et

➡️ Sağ Ok – Sağa hareket et

⬆️ Yukarı Ok – Zıpla

⬇️ Aşağı Ok – Eğil / Kay

✨ Özellikler
Prosedürel seviye üretimi: Her oynayışta farklı engeller ve yollar

Kahve Booster’ı ☕: Geçici hız artışı sağlar

Enerji İçeceği ⚡: Daha uzun süreli hızlanma

Kitap Toplama 📚: Bonus puan kazandırır

Engel Çeşitleri 🚧: Kaldırım taşları, trafik konileri, okul çantaları, koşan öğrenciler

Skor Sistemi: En yüksek skorun kaydedilir

Mobil Uyumluluk: Hem bilgisayar hem de mobil cihazlarda oynanabilir

🛠️ Kurulum
Bu repoyu indir veya klonla:

bash
Copy
Edit
git clone https://github.com/pinarciLate-For-School.git
Unity Hub üzerinden Open Project ile projeyi aç.

Unity Sürümü: 2021.3.x LTS (Mac/Windows uyumlu)

Scenes klasöründeki MainScene.unity sahnesini aç.

Play butonuna basarak çalıştır.

📦 Gereksinimler
Unity: 2021.3.x LTS

Platform Desteği:

Windows
macOS
Android
iOS

Modüller:

Mac Build Support (IL2CPP)

Android Build Support (mobil için)

iOS Build Support (opsiyonel)

🧑‍💻 Geliştirici Notları
LevelSpawner engel ve coin (ya da kitap) pozisyonlarını belirler.
Boş veya eksik referanslar IndexOutOfRangeException hatasına yol açabilir.

Yeni engel eklemek için:

Prefab oluştur

spawnObjects array’ine ekle

Yeni güçlendirme eklemek için:

Power-up prefab’ını oluşturup ilgili spawn noktalarına ekle

Kahve booster’ın süresini CoffeeBooster.cs scriptinden değiştirebilirsin

