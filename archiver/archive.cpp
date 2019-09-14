// "Copyright 2018 <Ipatov D.D.>"
#include <QMainWindow>
#include <JlCompress.h>
#include <fstream>

#include "archive.h"

Archive::Archive(const Archive& obj) { current_zip_ = obj.current_zip_; }

void Archive::operator=(const Archive& obj) { current_zip_ = obj.current_zip_; }

void Archive::table_output(QTableWidget& table) {
  if (current_zip_ != nullptr) {
    current_zip_->open(QuaZip::mdUnzip);
    int i = 0;
    for (bool f = current_zip_->goToFirstFile(); f;
         f = current_zip_->goToNextFile()) {
      QuaZipFileInfo file_info{};
      current_zip_->getCurrentFileInfo(&file_info);
      table.insertRow(i);
      table.setItem(i, 0, new QTableWidgetItem(file_info.name));
      table.setItem(i, 1, new QTableWidgetItem(
                              QString::number(file_info.uncompressedSize)));
      table.setItem(i, 2, new QTableWidgetItem(
                              QString::number(file_info.compressedSize)));
      table.setItem(i, 3, new QTableWidgetItem(
                              file_info.dateTime.toString("dd.MM.yyyy h:m")));
      table.setItem(i, 4, new QTableWidgetItem(file_info.comment));
      i++;
    }
    current_zip_->close();
  } else {
    throw std::invalid_argument("Empty Archive");
  }
}

bool Archive::create_new_zip(const QString& path) {
  int ind = 0;
  int indt = 0;
  for (int i = path.size() - 1; i >= 0; i--) {
    if (path.at(i) == '.') {
      indt = i;
    }
    if (path.at(i) == '/') {
      ind = i;
      break;
    }
  }
  QDir dir = path.left(ind);
  QFile file(path);
  if (file.exists()) {
    file.remove();
  }
  if (dir.mkdir(path.mid(ind + 1, indt - ind - 1))) {
    JlCompress::compressDir(path, path.left(indt), true);
    dir.rmdir(path.mid(ind + 1, indt - ind - 1));
    change_zip(path);
    return true;
  } else {
    throw std::invalid_argument("Bad path");
  }
}

bool Archive::add_new_files(const QStringList& strings) {
  if (current_zip_ != nullptr) {
    current_zip_->open(QuaZip::mdAdd);
    for (int i = 0; i < strings.size(); i++) {
      int ind = 0;
      for (int j = strings[i].size() - 1; j >= 0; j--) {
        if (strings[i].at(j) == '/') {
          break;
        }
        ind++;
      }
      QuaZipFile file(current_zip_);
      file.open(QIODevice::WriteOnly, QuaZipNewInfo(strings[i].right(ind)));
      QFile file_cur(strings[i]);
      file_cur.open(QIODevice::ReadOnly);
      QDataStream ts(&file);
      ts << file_cur.readAll();
      file_cur.close();
      file.close();
    }
    current_zip_->close();
    return true;
  } else {
    return false;
  }
}

bool Archive::unzip_to_folder(const QString& path) {
  if (current_zip_ != nullptr) {
    JlCompress::extractDir(path_, path);
    return true;
  }
  return false;
}

void Archive::zip_folder(const QString& path, const QString& path_save) {
  JlCompress::compressDir(path_save, path, true);
  change_zip(path_save);
}

Archive::Archive(const QString& name) { current_zip_ = new QuaZip(name); }

Archive::~Archive() { delete current_zip_; }

void Archive::change_zip(const QString& name) {
  path_ = name;
  delete current_zip_;
  current_zip_ = new QuaZip(name);
}
