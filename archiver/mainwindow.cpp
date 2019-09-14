// "Copyright 2018 <Ipatov D.D.>"
#include <QString>
#include <QFileDialog>
#include <JlCompress.h>
#include <QMessageBox>

#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "archive.h"

static Archive current_archive{};

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent), ui(new Ui::MainWindow) {
  ui->setupUi(this);
  ui->opened_zip->horizontalHeader()->resizeSections(
      QHeaderView::ResizeToContents);
  ui->opened_zip->setEditTriggers(QAbstractItemView::NoEditTriggers);
  ui->opened_zip->horizontalHeader()->setStretchLastSection(true);
  ui->opened_zip->setSortingEnabled(true);
  ui->path_archive->setReadOnly(true);
  QWidget::setWindowTitle("ZIPArchiver");
}

MainWindow::~MainWindow() { delete ui; }

void MainWindow::on_open_archive_triggered() {
  QFileDialog *fileDialog = new QFileDialog(this);
  QString path = fileDialog->getOpenFileName(0, "Выберите файл", "", "*.zip");
  if (path != "") {
    change_path(path);
    current_archive.change_zip(path);
    output_table();
  }
}

void MainWindow::on_exit_triggered() {
  QMessageBox::StandardButton reply =
      QMessageBox::question(this, "Выход", "Вы точно хотите выйти?",
                            QMessageBox::Yes | QMessageBox::No);
  if (reply == QMessageBox::Yes) {
    this->close();
  }
}

void MainWindow::on_create_archive_triggered() {
  QFileDialog *fileDialog = new QFileDialog(this);
  QString path = fileDialog->getSaveFileName(0, "Выберите путь создания архива",
                                             "", "*.zip");
  if (path != "") {
      current_archive.create_new_zip(path);
      change_path(path);
  }
}

void MainWindow::change_path(const QString& path) {
  ui->path_archive->setText(path);
  ui->opened_zip->setRowCount(0);
}

void MainWindow::output_table() {
  ui->opened_zip->setRowCount(0);
  current_archive.table_output(*ui->opened_zip);
}

void MainWindow::on_add_files_to_archive_triggered() {
  QFileDialog *fileDialog = new QFileDialog(this);
  QStringList path =
      fileDialog->getOpenFileNames(0, "Выберите файлы", "", "*.*");
  if (path.size() > 0) {
    if (!current_archive.add_new_files(path)) {
      QMessageBox::critical(this, "Ошибка", "Архив отсутствует");
    } else {
      output_table();
    }
  }
}

void MainWindow::on_unzip_to_folder_triggered() {
  QFileDialog *fileDialog = new QFileDialog(this);
  QString path = fileDialog->getExistingDirectory(0, "Выберите путь", "");
  if (path != "") {
    if (!current_archive.unzip_to_folder(path)) {
      QMessageBox::critical(this, "Ошибка", "Архив отсутствует");
    }
  }
}

void MainWindow::on_zipping_folder_triggered() {
  QFileDialog *fileDialog = new QFileDialog(this);
  QString path = fileDialog->getExistingDirectory(0, "Выберите директорию", "");
  QString path_save = fileDialog->getSaveFileName(
      0, "Выберите путь создания архива", "", "*.zip");
  if (path != "" && path_save != "") {
    current_archive.zip_folder(path, path_save);
    change_path(path_save);
    output_table();
  }
}

void MainWindow::on_help_triggered() {
  QMessageBox::information(
      this, "Помощь",
      "Для того, чтобы открыть архив перейдите во вкладку "
      "\"Файл\"-\"Открыть архив\" и выберите архив\n\n"
      "Чтобы создать новый архив, перейдите во вкладку "
      "\"Файл\"-\"Создать архив\" и выберите путь создания\n\n"
      "Чтобы добавить файлы в текущий архив, перейдите во вкладку "
      "\"Команды\"-\"Добавить файлы в архив\" "
      "и выберите файлы для архивации\n\n"
      "Чтобы разархивировать текущий архив, перейдите во вкладку "
      "\"Команды\"-\"Разархивировать в папку\" "
      "и выберите путь разархивации\n\n"
      "Чтобы заархивировать директории, перейдите во вкладку "
      "\"Команды\"-\"Заархивировать директории\" "
      "и выберите папку, а затем путь архивации\n\n"
      "Чтобы выйти из программы, перейдите во вкладку "
      "\"Файл\"-\"Выйти\"\n\n");
}
