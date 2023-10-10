using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordBox.Models;

[INotifyPropertyChanged]
public partial class PasswordInfo {
    private int passwordId = 0;
    private int groupId = 0;
    private int userId = 0;
    private DateTime createTime = DateTime.Now;
    private DateTime modifyTime = DateTime.Now;
    private string appName = string.Empty;
    private string account = string.Empty;
    private string password = string.Empty;
    private string phoneNumber = string.Empty;
    private string mailBox = string.Empty;
    private string website = string.Empty;
    private string note = string.Empty;
    private string icon = string.Empty;

    public int PasswordId {
        get => passwordId;
        set { passwordId = value; OnPropertyChanged(nameof(PasswordId)); }
    }
    public int GroupId {
        get => groupId;
        set { groupId = value; OnPropertyChanged(nameof(GroupId)); }
    }
    public int UserId {
        get => userId;
        set { userId = value; OnPropertyChanged(nameof(UserId)); }
    }
    public DateTime CreateTime {
        get => createTime;
        set { createTime = value; OnPropertyChanged(nameof(CreateTime)); }
    }
    public DateTime ModifyTime {
        get => modifyTime;
        set { modifyTime = value; OnPropertyChanged(nameof(ModifyTime)); }
    }
    public string AppName {
        get => appName;
        set { appName = value; OnPropertyChanged(nameof(AppName)); }
    }
    public string Account {
        get => account;
        set { account = value; OnPropertyChanged(nameof(Account)); }
    }
    public string Password {
        get => password;
        set { password = value; OnPropertyChanged(nameof(Password)); }
    }
    public string PhoneNumber {
        get => phoneNumber;
        set { phoneNumber = value; OnPropertyChanged(nameof(PhoneNumber)); }
    }
    public string MailBox {
        get => mailBox;
        set { mailBox = value; OnPropertyChanged(nameof(MailBox)); }
    }
    public string Website {
        get => website;
        set { website = value; OnPropertyChanged(nameof(Website)); }
    }
    public string Note {
        get => note;
        set { note = value; OnPropertyChanged(nameof(Note)); }
    }
    public string Icon {
        get => icon;
        set { icon = value; OnPropertyChanged(nameof(Icon)); }
    }
}