// 스크롤 이벤트에 따른 네비게이션 바 스타일 변경
window.addEventListener('scroll', function() {
    const navbar = document.querySelector('.navbar');
    if (window.scrollY > 50) {
        navbar.style.background = 'rgba(10, 10, 12, 0.95)';
        navbar.style.boxShadow = '0 4px 12px rgba(0, 0, 0, 0.5)';
    } else {
        navbar.style.background = '#111111';
        navbar.style.boxShadow = '0 2px 10px rgba(0, 0, 0, 0.5)';
    }
});

// 챔피언 카드 애니메이션
document.addEventListener('DOMContentLoaded', function() {
    const cards = document.querySelectorAll('.champion-card');
    
    // 카드들이 순차적으로 나타나는 효과
    cards.forEach((card, index) => {
        setTimeout(() => {
            card.style.opacity = '1';
            card.style.transform = 'translateY(0)';
        }, 100 * index);
    });
    
    // 카드에 마우스 오버 이벤트
    cards.forEach(card => {
        card.addEventListener('mouseenter', function() {
            const img = this.querySelector('.champion-img img');
            img.style.transform = 'scale(1.1)';
        });
        
        card.addEventListener('mouseleave', function() {
            const img = this.querySelector('.champion-img img');
            img.style.transform = 'scale(1)';
        });
    });
});

// 미리 카드 스타일 초기화 (CSS에서 추가하지 않은 부분)
document.addEventListener('DOMContentLoaded', function() {
    const cards = document.querySelectorAll('.champion-card');
    cards.forEach(card => {
        card.style.opacity = '0';
        card.style.transform = 'translateY(20px)';
        card.style.transition = 'opacity 0.5s ease, transform 0.5s ease';
    });
});

// 배너 이미지 패럴랙스 효과
window.addEventListener('scroll', function() {
    const banner = document.querySelector('.banner img');
    const scrollPosition = window.scrollY;
    
    if (scrollPosition <= 500) {
        banner.style.transform = `translateY(${scrollPosition * 0.3}px)`;
    }
});

// 검색 기능
document.querySelector('.search button').addEventListener('click', function(e) {
    e.preventDefault();
    const searchTerm = document.querySelector('.search input').value.toLowerCase();
    const championCards = document.querySelectorAll('.champion-card');
    
    championCards.forEach(card => {
        const championName = card.querySelector('h3').textContent.toLowerCase();
        if (championName.includes(searchTerm)) {
            card.style.display = 'block';
        } else {
            card.style.display = 'none';
        }
    });
});

// 입력 필드에서 엔터 키 눌렀을 때 검색 실행
document.querySelector('.search input').addEventListener('keypress', function(e) {
    if (e.key === 'Enter') {
        document.querySelector('.search button').click();
    }
});

// 초기 로딩 시 마스터리 바 애니메이션
document.addEventListener('DOMContentLoaded', function() {
    const masteryBars = document.querySelectorAll('.mastery-fill');
    
    setTimeout(() => {
        masteryBars.forEach(bar => {
            const width = bar.style.width;
            bar.style.width = '0%';
            
            setTimeout(() => {
                bar.style.transition = 'width 1s ease-out';
                bar.style.width = width;
            }, 300);
        });
    }, 1000); // 페이지 로드 후 1초 후에 애니메이션 시작
});