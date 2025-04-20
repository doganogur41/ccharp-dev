#include <iostream>
#include <vector>
#include <string>
#include <fstream>
#include <sstream>

using namespace std;

// İyilik faaliyeti sınıfı
class GoodDeed {
public:
    string activityName;
    string description;
    string date;
    int hoursContributed;

    GoodDeed(string name, string desc, string d, int hours)
        : activityName(name), description(desc), date(d), hoursContributed(hours) {}

    void displayDeed() const {
        cout << "Faaliyet: " << activityName << "\n";
        cout << "Açıklama: " << description << "\n";
        cout << "Tarih: " << date << "\n";
        cout << "Katkı Süresi: " << hoursContributed << " saat\n";
    }

    string toString() const {
        stringstream ss;
        ss << activityName << "," << description << "," << date << "," << hoursContributed;
        return ss.str();
    }
};

// Kullanıcı sınıfı
class User {
public:
    string username;
    vector<GoodDeed> deeds;

    User(string name) : username(name) {}

    void addDeed(const GoodDeed &deed) {
        deeds.push_back(deed);
    }

    void removeDeed(const string &activityName) {
        for (auto it = deeds.begin(); it != deeds.end(); ++it) {
            if (it->activityName == activityName) {
                deeds.erase(it);
                cout << activityName << " faaliyeti silindi.\n";
                return;
            }
        }
        cout << "Faaliyet bulunamadı!\n";
    }

    void displayUserDeeds() const {
        cout << username << "'in iyilik faaliyetleri:\n";
        if (deeds.empty()) {
            cout << "Henüz herhangi bir faaliyet kaydedilmemiş.\n";
        } else {
            for (const auto &deed : deeds) {
                deed.displayDeed();
                cout << "-------------------------\n";
            }
        }
    }

    int totalHours() const {
        int total = 0;
        for (const auto &deed : deeds) {
            total += deed.hoursContributed;
        }
        return total;
    }

    string getUsername() const {
        return username;
    }
};

// Küresel İyilik Sistemi
class GlobalGoodSystem {
public:
    vector<User> users;

    void addUser(const User &user) {
        users.push_back(user);
    }

    void removeUser(const string &username) {
        for (auto it = users.begin(); it != users.end(); ++it) {
            if (it->getUsername() == username) {
                users.erase(it);
                cout << username << " adlı kullanıcı silindi.\n";
                return;
            }
        }
        cout << "Kullanıcı bulunamadı!\n";
    }

    void addDeedToUser(const string &username, const GoodDeed &deed) {
        for (auto &user : users) {
            if (user.getUsername() == username) {
                user.addDeed(deed);
                cout << "Faaliyet başarıyla eklendi.\n";
                return;
            }
        }
        cout << "Kullanıcı bulunamadı!\n";
    }

    void displayAllUsersDeeds() const {
        if (users.empty()) {
            cout << "Sistemde kayıtlı kullanıcı yok.\n";
            return;
        }
        for (const auto &user : users) {
            user.displayUserDeeds();
        }
    }

    void displayGlobalStats() const {
        int globalHours = 0;
        for (const auto &user : users) {
            globalHours += user.totalHours();
        }
        cout << "Toplam İyilik Süresi: " << globalHours << " saat\n";
    }

    void saveData() const {
        ofstream file("good_deeds_data.txt");
        for (const auto &user : users) {
            for (const auto &deed : user.deeds) {
                file << user.getUsername() << "," << deed.toString() << "\n";
            }
        }
        cout << "Veriler kaydedildi.\n";
    }

    void loadData() {
        ifstream file("good_deeds_data.txt");
        string line;
        while (getline(file, line)) {
            stringstream ss(line);
            string username, activityName, description, date, hoursStr;
            int hours;
            getline(ss, username, ',');
            getline(ss, activityName, ',');
            getline(ss, description, ',');
            getline(ss, date, ',');
            getline(ss, hoursStr);
            hours = stoi(hoursStr);
            
            GoodDeed deed(activityName, description, date, hours);
            bool userFound = false;
            for (auto &user : users) {
                if (user.getUsername() == username) {
                    user.addDeed(deed);
                    userFound = true;
                    break;
                }
            }
            if (!userFound) {
                User newUser(username);
                newUser.addDeed(deed);
                users.push_back(newUser);
            }
        }
        cout << "Veriler başarıyla yüklendi.\n";
    }
};

// Yardımcı fonksiyonlar
void showMenu() {
    cout << "1. Kullanıcı Ekle\n";
    cout << "2. Kullanıcı Sil\n";
    cout << "3. İyilik Faaliyeti Ekle\n";
    cout << "4. Kullanıcı Faaliyetlerini Görüntüle\n";
    cout << "5. Sistemi Görüntüle\n";
    cout << "6. Küresel İstatistikleri Görüntüle\n";
    cout << "7. Verileri Kaydet\n";
    cout << "8. Verileri Yükle\n";
    cout << "9. Çıkış\n";
}

int main() {
    GlobalGoodSystem system;
    system.loadData();  // Veriyi yükle

    int choice;
    string username, activityName, description, date;
    int hours;

    while (true) {
        showMenu();
        cout << "Seçiminizi yapın: ";
        cin >> choice;
        cin.ignore();  // Buffered input'u temizle

        switch (choice) {
            case 1: // Kullanıcı Ekle
                cout << "Kullanıcı adı girin: ";
                getline(cin, username);
                system.addUser(User(username));
                break;

            case 2: // Kullanıcı Sil
                cout << "Silmek istediğiniz kullanıcı adını girin: ";
                getline(cin, username);
                system.removeUser(username);
                break;

            case 3: // İyilik Faaliyeti Ekle
                cout << "Kullanıcı adı girin: ";
                getline(cin, username);
                cout << "Faaliyet adı: ";
                getline(cin, activityName);
                cout << "Açıklama: ";
                getline(cin, description);
                cout << "Tarih (yyyy-aa-gg): ";
                getline(cin, date);
                cout << "Katkı süresi (saat): ";
                cin >> hours;
                cin.ignore();
                system.addDeedToUser(username, GoodDeed(activityName, description, date, hours));
                break;

            case 4: // Kullanıcı Faaliyetlerini Görüntüle
                cout << "Kullanıcı adı girin: ";
                getline(cin, username);
                for (const auto &user : system.users) {
                    if (user.getUsername() == username) {
                        user.displayUserDeeds();
                        break;
                    }
                }
                break;

            case 5: // Sistemi Görüntüle
                system.displayAllUsersDeeds();
                break;

            case 6: // Küresel İstatistikleri Görüntüle
                system.displayGlobalStats();
                break;

            case 7: // Verileri Kaydet
                system.saveData();
                break;

            case 8: // Verileri Yükle
                system.loadData();
                break;

            case 9: // Çıkış
                cout << "Çıkılıyor...\n";
                return 0;

            default:
                cout << "Geçersiz seçenek, tekrar deneyin.\n";
        }
    }

    return 0;
}
