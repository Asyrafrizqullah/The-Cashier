# The Cashier

Aplikasi Hitung total pendapatan dari usaha dan menampilkan list yang sudah memesan Barang atau Jasa dari usaha.

## Fungsi
- Mendata Penjualan Menjadi Lebih Mudah
- List Penjualan Menjadi Lebih Jelas dan Valid
- Bisa Langsung Melihat Total Penghasilan

## Cara Keja
- Pertama, Admin atau kasir akan disambut dangan form sederhana.
- Kedua, Admin atua kasir diminta untuk mengisi form tersebut atau bisa dibilang melakukan proses pendataan.
-  Ketiga, Setelah Mengisi form tersebut maka Admin atau kasir bisa langsung lihat hasilnya

## Kelebihan dan Kekurangan
### - Kelebihan
- Mendata Jadi Lebih Jelas
- Mudah Dipahami
- Hasil Valid
- Simpel

### - Kekurangan
- Saat keluar program data langsung ke-reset
- Kurang Berwarna

## Penjelasan Coding
Pada Program ini saya akan menjelaskan sedikit pada bagian Tabel List dan Total saja. Pada Tabel List saya menggunakan 2 ListBox yang ditumpuk untuk Listbox pertama digunakan untuk membuat nama (Item, Type, Jumlah, Harga(Rp)) dengan koding seperti berikut : 
    
    <ListBox HorizontalAlignment="Left" Height="40" Margin="40,350,0,0" VerticalAlignment="Top" Width="490" >
            <Grid>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="150" />
                    <ColumnDefinition Width="110" />
                    <ColumnDefinition Width="100" />
                    <ColumnDefinition Width="100" />
                </Grid.ColumnDefinitions>
                <TextBlock Grid.Column="0" Text="Item" FontSize="20" FontWeight="Bold" TextAlignment="Center" Margin="0,0,0,-15"/>
                <TextBlock Grid.Column="1" Text="quantity" FontSize="20" FontWeight="Bold" TextAlignment="Center" Margin="0,0,0,-15"/>
                <TextBlock Grid.Column="2" Text="price" FontSize="20" FontWeight="Bold" TextAlignment="Center" Margin="0,0,0,-15"/>
                <TextBlock Grid.Column="3" Text="subtotal" FontSize="20" FontWeight="Bold" TextAlignment="Center" Margin="0,0,0,-15"/>
            </Grid>
        </ListBox>
        <ListBox x:Name="ListBox" HorizontalAlignment="Left" Height="200" Margin="40,400,0,0" VerticalAlignment="Top" Width="490">
            <ListBox.ItemTemplate>
                <DataTemplate>
                    <Grid Margin="0,2">
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="150" />
                            <ColumnDefinition Width="110" />
                            <ColumnDefinition Width="100" />
                            <ColumnDefinition Width="100" />
                        </Grid.ColumnDefinitions>
                        <TextBlock Grid.Column="0" Text="{Binding title}" FontSize="20" TextAlignment="Center" Margin="0,0,0,-15"/>
                        <TextBlock Grid.Column="1" Text="{Binding quantity}" FontSize="20" TextAlignment="Center" Margin="0,0,0,-15"/>
                        <TextBlock Grid.Column="2" Text="{Binding price}" FontSize="20" TextAlignment="Center" Margin="0,0,0,-15"/>
                        <TextBlock Grid.Column="3" Text="{Binding subtotal}" FontSize="20" TextAlignment="Center" Margin="0,0,0,-15"/>
                    </Grid>
                </DataTemplate>
            </ListBox.ItemTemplate>
        </ListBox>

Untuk ListBox yang kedua saya gunakan untuk isi atau hasil dari form-nya dengan koding seperti berikut : 

     <ListBox x:Name="ListBox" HorizontalAlignment="Left" Height="200" Margin="40,400,0,0" VerticalAlignment="Top" Width="490">
            <ListBox.ItemTemplate>
                <DataTemplate>
                    <Grid Margin="0,2">
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="150" />
                            <ColumnDefinition Width="110" />
                            <ColumnDefinition Width="100" />
                            <ColumnDefinition Width="100" />
                        </Grid.ColumnDefinitions>
                        <TextBlock Grid.Column="0" Text="{Binding title}" FontSize="20" TextAlignment="Center" Margin="0,0,0,-15"/>
                        <TextBlock Grid.Column="1" Text="{Binding quantity}" FontSize="20" TextAlignment="Center" Margin="0,0,0,-15"/>
                        <TextBlock Grid.Column="2" Text="{Binding price}" FontSize="20" TextAlignment="Center" Margin="0,0,0,-15"/>
                        <TextBlock Grid.Column="3" Text="{Binding subtotal}" FontSize="20" TextAlignment="Center" Margin="0,0,0,-15"/>
                    </Grid>
                </DataTemplate>
            </ListBox.ItemTemplate>
        </ListBox>

Selanjutnya Bagian Total, Pada bagian total saya membutuhkan Tabel List dan Class baru (Class Item Untuk mendata atau mendeklarasikan varible yang dibutuhka dan yang kedua ada Class Calculator Untuk melakukan proses setelahh itu dikembalikan ke MainWindow.xaml.cs) pada Class Item ada satu koding seperti ini : 

    public double getSubTotal()
        {
            subtotal = price * quantity;
            return subtotal;
        }

Koding tersebut digunakan untuk menghitung total yang kalau diartikan "subtotal adalah harga dikali dengan jumlah" setelah dihitung dan ketemu, hasilnya akan dimasukkan ke dalam Koding tersebut digunakan untuk menghitung total yang kalau diartikan "subtotal adalah harga dikali dengan jumlah" setelah dihitung dan ketemu, hasilnya akan dimasukkan ke dalam getSubTotal() dan kemudian ditampilkan.
